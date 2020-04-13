# Makefile for: IVS projekt 2 - Kalkulačka - tím Orient Express - 2019/20
# 2020-04-08


CWD=$(shell cd)\..
Visual_Stuio_dir="C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\MSBuild"
tmp_name=xoleks00_xfindr00_xkromp00_xkruzi04
zip_name=xoleks00_xfindr00_xkromp00_xkruzi04.zip

# (spustí progam)
all: 
	cd $(Visual_Stuio_dir) & Current\Bin\MSBuild.exe "$(CWD)\src\Kalkulacka\Kalkulacka.sln" /t:Build & $(CWD)\Kalkulacka\obj\Debug\Kalkulacka.exe

# (zabalí projekt tak, aby mohl být odevzdán)
pack: 	
	cd .. & cd .. & if exist "$(tmp_name)" rmdir "$(tmp_name)" /s /q
	cd .. & cd .. & mkdir $(tmp_name) & cd $(tmp_name) & mkdir repo & mkdir doc & mkdir install
	cd .. & cd .. & xcopy /s IVS-projekt xoleks00_xfindr00_xkromp00_xkruzi04\repo 

	
#powershell Compress-Archive -Path C:\Users\Admin\Documents\IVS\IVS-projekt\xoleks00_xfindr00_xkromp00_xkruzi04 -DestinationPath C:\Users\Admin\Documents\IVS\IVS-projekt\ahoj.zip
# (smaže všechny soubory, co nemají být odevzdány)
clean: 

# (spustí program)
run: 
	cd $(Visual_Stuio_dir) & Current\Bin\MSBuild.exe "$(CWD)\src\Kalkulacka\Kalkulacka.sln" /t:Build & $(CWD)\src\Kalkulacka\obj\Debug\Kalkulacka.exe

# (spustí program pro výpočet směrodatné odchylky s ukázkovým testovacím vstupem)
profile: 
	cd $(CWD) & Profiling\bin\Release\Profiling.exe < data.txt

# (vypíše nápovědu s popisem, co je potřeba udělat před spuštěním programu)
help: 
