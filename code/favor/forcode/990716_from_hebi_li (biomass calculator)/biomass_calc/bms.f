CCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC
C																	C
C			PROGRAM FOR BIOMASS CALCULATION IN        		    	C
C			A SINGLE ACTIVATED SLUDGE PROCESS 						C
C																	C
C---------------------------------------------------------------------C
C																	C
C	LIST OF VARIABLES		        								C
C																	C
C	N - NUMBER OF CMFRS		    									C
C	NPC - NUMBER OF PRIMARY CLARIFIER								C
C	NAB - NUMBER OF AERATION BASIN									C
C	NSC - NUMBER OF SECONDARY CLARIFIER								C
C	NSF - STEP FEED OPTION:NSF=0(NO STEP FEED),NSF=1(STEP FEED)     C
C	MUM - MAXIMUM GROWTH RATE CONSTANT								C
C	KS - HALF VELOCITY CONSTANT										C
C	KD - BACTERIAL DECAY CONSTANT									C
C	Y - YIELD COEFFICIENT											C
C	Q0 - PLANT FLOWRATE												C
C	QW1 - WASTAGE FLOWRATE FROM EACH PRIMARY CLARIFIER				C
C	QW - WASTAGE FLOWRATE FROM EACH SECONDARY CLARIFIER             C
C	QR - RECYCLE FLOWRATE FROM EACH SECONDARY CLARIFIER				C
C	X0 - SOLIDS CONCENTRATION IN THE INFLUENT						C
C	XSC - SOLIDS CONCENTRATION IN THE EFFLUENT						C
C	S0 - INFLUENT SUBSTRATE CONCENTRATION							C
C	FFRACT(N) - STEP FEED FRACTION TO EACH CMFR                     C
C	X(1)~X(N) - BIOMASS CONCENTRATION IN EACH CMFR  				C
C	X(N+1)~X(2*N) - SUBSTRATE CONCENTRATION IN EACH CMFR			C
C	V(N) - VOLUME OF EACH CMFR 										C
C	ITMAX - MAXIMUM NUMBER OF ITERATIONS							C
C	ERRREL - STOPPING CRITERIA										C
C     FNORM -  A SCALAR THAT HAS THE VALUE F(1)^2+...+F(N)^2 AT THE 	C
C              POINT X												C
C	DNEQNF - A LIBRARY FUNCTION TO SOLVE A SYSTEM OF EQUATIONS      C
C              USING A MODIFIED POWELL HYBRID ALGORITHM WITH A        C
C              FINITE-DIFFERENCE APPROXIMATION TO THE JACOBIAN.
C	FCN - USER-SUPPLIED SUBROUTINE TO EVALUATE THE SYSTEM OF 		C
C           EQUAIOTNS TO BE SOLVED                                    C
C						                                            C
CCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC


	INCLUDE 'vbms.f'


	DOUBLE PRECISION ERRREL,FNORM,XPC,XSC,RE
	DOUBLE PRECISION S0,X0,Q0,QW1,QR,QW,QE,QED,QRD,QTD,QSC
	INTEGER NSF,NPC,NAB,NSC,ITMAX
	DOUBLE PRECISION,DIMENSION(1:10)::FFRACT
	DOUBLE PRECISION,DIMENSION(1:20)::X,XGUESS
	INTEGER M,I
	EXTERNAL FCN,DNEQNF
	
cccc	OPEN(UNIT=10,FILE='H:\favor\indata.dat')
	OPEN(UNIT=10,FILE='indata.dat')


	READ(10,25) N

	READ(10,25) NSF

	DO 15 I=1,N
	   READ(10,20) FFRACT(I)
  15  CONTINUE


	READ(10,25) NPC

	READ(10,25) NAB

	READ(10,25) NSC

	READ(10,20) Q0

	READ(10,20) QW1

	READ(10,20) QW

	READ(10,20) QR

	READ(10,20) XSC

	READ(10,20) RE

	DO 18 I=1,N
	   READ(10,20) V(I)
  18  CONTINUE

	READ(10,20) MUM

	READ(10,20) KS

	READ(10,20) KD

	READ(10,20) Y

	READ(10,20) S0

	READ(10,20) X0

	READ(10,25) ITMAX

	READ(10,20) ERRREL

	CLOSE(UNIT=10)

  20  FORMAT(E12.5)
  25  FORMAT(I5)

	QE=(Q0/DFLOAT(NPC))-QW1
	QED=QE*DFLOAT(NPC)/DFLOAT(NAB)
	QRD=QR*DFLOAT(NSC)/DFLOAT(NAB)
	QTD=QED+QRD
	QSC=QTD*DFLOAT(NAB)/DFLOAT(NSC)
	X0=0.8*X0
	XSC=0.8*XSC
	XPC=(1-RE)*Q0*X0/(Q0-QW1*DFLOAT(NPC))
	
	A=(QRD*QSC)/(QTD*(QW+QR))
	B=((QSC-QW-QR)*QRD*XSC)/(QTD*(QW+QR))
	C=(QED*XPC)/QTD
	D=QRD/QTD
	E=(QED*S0)/QTD
	

	IF((NSF.EQ.0).OR.(N.EQ.1))THEN
	   FFRACT(1)=1.D0
	   IF(N.GT.1) THEN
	      DO 30 I=2,N
	         FFRACT(I)=0.D0
  30	      CONTINUE 
	    ENDIF
	ENDIF

	IF(NSF.EQ.1) QNF(1)=QTD*FFRACT(1)
	IF(NSF.EQ.0) QNF(1)=QTD
	IF(NSF.EQ.1) QN(1)=QTD*FFRACT(1)
	IF(NSF.EQ.0) QN(1)=QTD

	IF(N.GT.1) THEN

	   DO 40 I=2,N
	   
	      IF(NSF.EQ.1) QNF(I)=FFRACT(I)*QTD
	      IF(NSF.EQ.0) QNF(I)=0
	      IF(NSF.EQ.1) QN(I)=QN(I-1)+QNF(I)
	      IF(NSF.EQ.0) QN(I)=QTD

  40     CONTINUE
      ENDIF


C	INITIAL GUESS
      DO 50 I=1,N
	   XGUESS(I)=3500
	   XGUESS(N+I)=0.1*S0	   
  50  CONTINUE

	M=2*N

	CALL DNEQNF(FCN,ERRREL,M,ITMAX,XGUESS,X,FNORM)


cccc	OPEN(UNIT=20,FILE='H:\favor\out.dat')
	OPEN(UNIT=20,FILE='out.dat')

	DO 60 I=1,N
cccc	   WRITE(20,80) I,X(I),X(N+I)
	   WRITE(20,*) I
	   WRITE(20,*) X(I)
	   WRITE(20,*) X(N+I)
  60  CONTINUE


      CLOSE(UNIT=20)


  80  FORMAT(' ',I4,2E12.4)

	STOP
	END

	SUBROUTINE FCN(X,F,M)

	INCLUDE 'vbms.f'

	INTEGER M,I
	DOUBLE PRECISION, DIMENSION (1:M)::X, F

      
	F(1)=QN(1)*X(1)-((MUM*X(N+1)/(KS+X(N+1)))-KD)*V(1)*X(1)-
	+     A*QNF(1)*X(N)+(B-C)*QNF(1)
	F(N+1)=QN(1)*X(N+1)+(MUM*X(1)*V(1)/(Y*(KS+X(N+1))))*X(N+1)-
	+       D*QNF(1)*X(2*N)-E*QNF(1)

	IF(N .GT. 1) THEN

	  DO 90 I=2,N
	     F(I)=-QN(I-1)*X(I-1)+QN(I)*X(I)-((MUM*X(N+I)/(KS+X(N+I)))
	+	 -KD)*V(I)*X(I)-A*QNF(I)*X(N)+(B-C)*QNF(I)
	     F(N+I)=-QN(I-1)*X(N+I-1)+QN(I)*X(N+I)+(MUM*X(I)*V(I)/
	+	        (Y*(KS+X(N+I))))*X(N+I)-D*QNF(I)*X(2*N)-E*QNF(I)

  90    CONTINUE

	ENDIF


	RETURN
	END

