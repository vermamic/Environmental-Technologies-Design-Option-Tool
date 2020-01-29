      SUBROUTINE DIFFUN(N,T,YO,YDOT)
      IMPLICIT NONE
C
      INTEGER MAXIRREV,MAXPHOT,MAXREV,MAXODE,MAXWVLEN,MAXCOMP,MAXSTEPS
	INTEGER MAXNTARGET,MAXNTANK,MAXEQUATN
C
      PARAMETER (MAXIRREV=100)
      PARAMETER (MAXPHOT=20)
      PARAMETER (MAXREV=20)
      PARAMETER (MAXODE=30)
      PARAMETER (MAXWVLEN=100)
      PARAMETER (MAXCOMP=50)
      PARAMETER (MAXSTEPS=2000)
	PARAMETER (MAXNTARGET=10)
	PARAMETER (MAXNTANK=25)
      PARAMETER (MAXEQUATN=MAXODE*MAXNTANK)
C
      INTEGER COMPA(MAXIRREV),COMPB(MAXIRREV),
     +        COMPC(MAXIRREV),COMPD(MAXIRREV),
     +        COMPE(MAXREV),COMPF(MAXREV),
     +        COMPG(MAXPHOT),COMPH(MAXPHOT)
C
	INTEGER IDREACT,NODE,NIRREV,NTANK
      INTEGER I,N,J
C
	INTEGER NMONOACID,NMULTIACID,NTARGET
	INTEGER NCARBN(MAXNTARGET),NSUBSTT(MAXNTARGET)
C
	INTEGER NWVLEN,NPHOT
C
C      DOUBLE PRECISION RTHMO(MAXODE,MAXIRREV)      
      DOUBLE PRECISION CONCINI(MAXCOMP),
	+                 CONC(MAXEQUATN+MAXNTANK,0:MAXSTEPS)
C
      DOUBLE PRECISION UVI(MAXWVLEN),EXTCOEF(MAXPHOT,MAXWVLEN),
     +          QUATYD(MAXPHOT,MAXWVLEN),STOCPHOT(MAXPHOT),UVPATHL,
     +          RUVG(MAXCOMP,MAXNTANK),RUVH(MAXCOMP,MAXNTANK),
	+          RUVG_TANK(MAXCOMP),RUVH_TANK(MAXCOMP)
C      
      DOUBLE PRECISION TAU,HYG(MAXNTANK),PH(MAXNTANK,0:MAXSTEPS)
C
      DOUBLE PRECISION YDOT(MAXEQUATN),YO(MAXEQUATN),YOIONS(MAXEQUATN),
     &                 YOPHOTO(MAXEQUATN)
      DOUBLE PRECISION XK(MAXIRREV),XKE(MAXREV)
      DOUBLE PRECISION T
C
	DOUBLE PRECISION UNKNOWN_ION,ANIONNEW(MAXNTANK),ANION_IN_FCN
	DOUBLE PRECISION CONVER(MAXNTARGET,MAXNTANK)
	DOUBLE PRECISION NEWCO2(MAXNTANK),NEWSUBION(MAXNTANK)
C
	INTEGER NUM_TRIES
	INTEGER LDFJAC
      PARAMETER (LDFJAC=2)
	INTEGER IPARAM(7),ITP,NOUT
C
	DOUBLE PRECISION FJAC(LDFJAC,1), FSCALE(1), FVEC(1),
     +                 RPARAM(7), X(1), XGUESS(1),
     +                 XLB(1), XS(1), XUB(1)
C
	EXTERNAL FCN, UMACH
C
      COMMON /DATA1/ IDREACT,TAU,NTANK
      COMMON /DATA2/ NMONOACID,NMULTIACID,XKE,UNKNOWN_ION
      COMMON /DATA3/ CONCINI,CONC,HYG,XK,NODE,NIRREV,
     +               COMPA,COMPB,COMPC,COMPD,COMPE,COMPF
C
	COMMON /PHOTO1/ NWVLEN,NPHOT,UVPATHL,EXTCOEF,QUATYD,UVI,STOCPHOT
	COMMON /PHOTO2/ COMPG,COMPH
	COMMON /PHOTO3/ YOPHOTO
C
	COMMON /CHARGE/NTARGET,NCARBN,NSUBSTT,PH
	COMMON /IONS/ ANION_IN_FCN,YOIONS 
C
C-----call PHOTORATE subroutine to calculate photolysis rates	in each tank
C
C-----save yo's in yophoto's for the purpose of call photorate and then call PHOTORATE
	DO I = 1, N
	  YOPHOTO(I)=YO(I)
	ENDDO
C
	DO I = 1, NTANK
	  DO J = 1, NODE
		YOPHOTO(J)=YOPHOTO((I-1)*NODE+J)
		CALL PHOTORATE(RUVG_TANK,RUVH_TANK)
		RUVG(COMPG(J),I)=RUVG_TANK(COMPG(J))
		RUVH(COMPH(J),I)=RUVH_TANK(COMPH(J))
	  ENDDO
	ENDDO 
C
C-----call DBCLSF subrutine to calculate pH after each simulation step
C
C-----save yo's for ionized compounds in yoions's for the purpose of call FCN in DBCLSF
	DO I = 1, N
	  YOIONS(I)=YO(I)
      ENDDO
C-----calculate anions concentration produced in each tank
	DO I = 1, NTARGET
	  DO J = 1, NTANK
		CONVER(I,J)=(CONC(I+1,0)-YO(I+1+NODE*(J-1)))
	+                *(1.0+XKE(I+1)/HYG(J))
	  ENDDO
	ENDDO
	DO J = 1, NTANK
	  NEWCO2(J)=0
	  NEWSUBION(J)=0
	ENDDO
	DO I = 1, NTARGET
	  DO J = 1, NTANK
	    NEWCO2(J)=NEWCO2(J)+NCARBN(I)*CONVER(I,J)
	    NEWSUBION(J)=NEWSUBION(J)+NSUBSTT(I)*CONVER(I,J)
	  ENDDO
      ENDDO
	DO J = 1, NTANK
        ANIONNEW(J)=NEWCO2(J)/(1.0+HYG(J)/XKE(NMONOACID+NMULTIACID+1)
	+                     +XKE(NMONOACID+1)/HYG(J))
     +          +2*NEWCO2(J)*(XKE(NMONOACID+1)/HYG(J))
     +                   /(1.0+HYG(J)/XKE(NMONOACID+NMULTIACID+1)
     +               +XKE(NMONOACID+1)/HYG(J))
     +          +NEWSUBION(J)
	ENDDO
C
C-----call DBCLSF to calculate new pH value in each tank based on charge balance
C
	DO J = 1,NTANK
	  XGUESS(1) = PH(1,0)
	  CALL UMACH (2,NOUT)
	  NUM_TRIES = 0
	  XLB(1) = 1.0D0
        XUB(1) = 14.0D0 
        XS(1) = 1.0D0
        FSCALE(1) = 1.0D0  
C-----All the bounds are provided
        ITP = 0
C-----Default parameters are used
        IPARAM(1) = 0
C
	  ANION_IN_FCN = ANIONNEW(J)
        CALL DBCLSF (FCN, 1, 1, XGUESS, ITP, XLB, XUB, XS, 
     +             FSCALE,IPARAM, RPARAM, X, FVEC, FJAC, LDFJAC)
C
        HYG(J) = 10**(-X(1))
	ENDDO
C
C-----end of new pH calculation
C
C-----call ODEQUATN to get ordinary differential equations
C 
 	CALL ODEQUATN(N,T,YO,YDOT,RUVG,RUVH,XKE,NPHOT)
C  
      RETURN
      END
C
      SUBROUTINE PEDERV(N,T,Y,PD,NO)
      IMPLICIT DOUBLE PRECISION (A-H,O-Z)
      RETURN
      END 


