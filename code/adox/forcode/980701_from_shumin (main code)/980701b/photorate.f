	SUBROUTINE PHOTORATE(RUVG_TANK,RUVH_TANK) 
      IMPLICIT NONE
C
	INTEGER MAXPHOT,MAXWVLEN,MAXCOMP,MAXODE,MAXEQUATN,MAXNTANK
C
      PARAMETER (MAXPHOT=20)
      PARAMETER (MAXWVLEN=100)
      PARAMETER (MAXCOMP=50)
	PARAMETER (MAXODE=30)
	PARAMETER (MAXNTANK=25)
	PARAMETER (MAXEQUATN=MAXODE*MAXNTANK)
C
	INTEGER NWVLEN,NPHOT,COMPG(MAXPHOT),COMPH(MAXPHOT)
	INTEGER I,J
C
      DOUBLE PRECISION UVI(MAXWVLEN),ABSORB(MAXWVLEN),TOPTDEN(MAXWVLEN),
     +          EXTCOEF(MAXPHOT,MAXWVLEN),OPTDEN(MAXPHOT,MAXWVLEN),
     +          QUATYD(MAXPHOT,MAXWVLEN),FRACTUV(MAXPHOT,MAXWVLEN),          
     +          RATEUV(MAXPHOT,MAXWVLEN),TRATEUV(MAXPHOT),
	+		  STOCPHOT(MAXPHOT),UVPATHL,YOPHOTO(MAXEQUATN),
     +          RUVG_TANK(MAXCOMP),RUVH_TANK(MAXCOMP)          
C
	COMMON /PHOTO1/ NWVLEN,NPHOT,UVPATHL,EXTCOEF,QUATYD,UVI,STOCPHOT
	COMMON /PHOTO2/ COMPG,COMPH
	COMMON /PHOTO3/ YOPHOTO
C
C-----calculate light absorbence and photolysis rate
C
      DO I = 1, NWVLEN
          TOPTDEN(I)=0 
          DO J = 1, NPHOT
              OPTDEN(J,I)=2.303*UVPATHL*EXTCOEF(J,I)*YOPHOTO(COMPG(J))
              TOPTDEN(I)=TOPTDEN(I)+OPTDEN(J,I)
          ENDDO
          DO J = 1, NPHOT
              FRACTUV(J,I)=OPTDEN(J,I)/TOPTDEN(I)
          ENDDO
          ABSORB(I)=1.0-EXP(-TOPTDEN(I))
      ENDDO
C
      DO I = 1, NPHOT
          TRATEUV(I)=0
          DO J = 1, NWVLEN
              RATEUV(I,J)=-QUATYD(I,J)*UVI(J)*FRACTUV(I,J)*ABSORB(J)
              TRATEUV(I)=TRATEUV(I)+RATEUV(I,J)
          ENDDO     
      ENDDO
C
C------assign calculated photolysis rates to the specific compounds
C       -- COMPG(1)=1 -- H2O2, COMPG(2)=2, -- R1 
C       -- COMPG(3)=3 -- R2, COMPG(4)=7 -- NOM
C
      DO I = 1, NPHOT
          RUVG_TANK(COMPG(I))=TRATEUV(I)
          RUVH_TANK(COMPH(I))=-STOCPHOT(I)*TRATEUV(I)
      ENDDO
C
C------end of photolysis rate calculate
C
	RETURN
	END