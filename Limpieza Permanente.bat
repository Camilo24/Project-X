@echo Limpiador Windows por Camilo
cd %temp%
del * / S / Q
rmdir / S / Q "%temp%"
cd C:\Windows\Temp
del * / S / Q
rmdir / S / Q "C:\Windows\Temp"
cd C:\Windows\Prefetch
del * / S / Q
rmdir / S / Q "C:\Windows\Prefetch"
@echo Limpieza realizada
exit