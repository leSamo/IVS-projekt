# Makefile for: IVS projekt 2 - Kalkulačka - tím Orient Express - 2019/20
# 2020-04-08

CWD=$(shell cd)
Visual_Stuio_dir="C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\MSBuild"
tmp_name=xoleks00_xfindr00_xkromp00_xkruzi04
zip_name=xoleks00_xfindr00_xkromp00_xkruzi04.zip

.PHONY: all

# (spustí progam)
all:
	cd $(Visual_Stuio_dir) & Current\Bin\MSBuild.exe "$(CWD)\Kalkulacka\Kalkulacka.sln" /t:Build & $(CWD)\Kalkulacka\bin\Debug\Kalkulacka.exe

# (zabalí projekt tak, aby mohl být odevzdán)   
pack: 	
	cd .. & cd .. & if exist "$(tmp_name)" rmdir "$(tmp_name)" /s /q
	cd .. & cd .. & mkdir $(tmp_name) & cd $(tmp_name) & mkdir repo & mkdir doc & mkdir install
	cd .. & cd .. & xcopy /s IVS-projekt $(tmp_name)\repo /Q > nul
	cd .. & cd .. & xcopy /s 
	cd .. & cd .. & powershell Compress-Archive -Path $(tmp_name) -DestinationPath $(zip_name) 

# (smaže všechny soubory, co nemají být odevzdány)
clean: 

# (spustí program)
run: 
	cd $(Visual_Stuio_dir) & Current\Bin\MSBuild.exe "$(CWD)\Kalkulacka\Kalkulacka.sln" /t:Build & $(CWD)\src\Kalkulacka\obj\Debug\Kalkulacka.exe

# (spustí program pro výpočet směrodatné odchylky s ukázkovým testovacím vstupem)
profile: 
	Profiling\obj\Debug\Profiling.exe < data.txt

# (vypíše nápovědu s popisem, co je potřeba udělat před spuštěním programu)
help: 
	@echo "Pre build a spustenie programu zadaj 'make run/all'"
	@echo "Pre spustenie profilingu zadaj 'make profile'(vsupné data sú v súbore \repo\src\data.txt)"
	@echo "Pre vytvorenie .zip súboru s projektom na odovzdanie zadaj 'make pack'"
	@echo "Pre vyčistenie projektu od pre odovzdanie zbytočných súborov zadaj 'make clean'"
	@echo "Viac info o programe viď programová dokumentácia /doc"
	@echo "V prípade otázok/návrhov/sťažností kontaktujte xoleks00@stud.fit.vutbr.cz alebo xfindr00@stud.fit.vutbr.cz alebo xkromp00@stud.fit.vutbr.cz alebo xkruzi04@stud.fit.vutbr.cz"
