!C********************************************************************
!C
!C                             TEMPCNV
!C              CONVERT TEMPERATURE UNITS FROM C TO F  
!C
!C Description:  This SUBROUTINE will convert a temperature
!C               from units of C to units of F.
!C
!C Output Variables:
!C    TEMPENG =  Temperature (F)
!C
!C Input Variables:
!C    TEMPSI =   Temperature (C)
!C
!C History:
!C    Function written by D. Hokanson (6/14/94)
!C
!C********************************************************************

SUBROUTINE TEMPCNV(TEMPENG,TEMPSI)
!MS$ ATTRIBUTES DLLEXPORT, STDCALL::TEMPCNV
!MS$ ATTRIBUTES ALIAS:'_TEMPCNV':: TEMPCNV
!MS$ ATTRIBUTES REFERENCE::TEMPENG,TEMPSI

      IMPLICIT DOUBLE PRECISION (A-H,O-Z)
      DOUBLE PRECISION TEMPENG, TEMPSI

 TEMPENG = TEMPSI * (9.0D0/5.0D0) + 32.0D0         

END	SUBROUTINE

!C********************************************************************
