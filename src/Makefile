# Makefile for: IVS projekt 2 - Kalkulačka - tím Orient Express - 2019/20
# 2020-04-08

CWD=$(shell cd)
Visual_Stuio_dir="C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\MSBuild"
tmp_name=xoleks00_xfindr00_xkromp00_xkruzi04
zip_name=xoleks00_xfindr00_xkromp00_xkruzi04.zip

.PHONY: all

# (spustí progam)
all:
	cd $(Visual_Stuio_dir) & Current\Bin\MSBuild.exe "$(CWD)\Kalkulacka\Kalkulacka.sln" /t:Build & "$(CWD)\Kalkulacka\bin\Debug\Kalkulacka.exe"

# (zabalí projekt tak, aby mohl být odevzdán)   
pack: 	
	cd .. & cd .. & if exist "$(tmp_name)" rmdir "$(tmp_name)" /s /q
	cd .. & cd .. & mkdir $(tmp_name) & cd $(tmp_name) & mkdir repo & mkdir doc & mkdir install
	cd .. & cd .. & xcopy /s IVS-projekt\deploy $(tmp_name)\install /Q > nul
	cd .. & cd .. & xcopy /s IVS-projekt\dokumentace.pdf $(tmp_name)\doc /Q > nul
	make clean
	cd .. & cd .. & xcopy /s IVS-projekt $(tmp_name)\repo /Q > nul
	cd .. & cd .. & powershell Compress-Archive -Path $(tmp_name) -DestinationPath $(zip_name) 
	cd .. & cd .. & if exist "$(tmp_name)" rmdir "$(tmp_name)" /s /q

# (smaže všechny soubory, co nemají být odevzdány)
clean:
	cd .. & if exist "deploy" rmdir "deploy" /s /q
	cd .. & if exist "dokumentace.pdf" del "dokumentace.pdf" /s /q
    
# (spustí program)
run: 
	cd $(Visual_Stuio_dir) & Current\Bin\MSBuild.exe "$(CWD)\Kalkulacka\Kalkulacka.sln" /t:Build & "$(CWD)\src\Kalkulacka\obj\Debug\Kalkulacka.exe"

# (spustí program pro výpočet směrodatné odchylky s ukázkovým testovacím vstupem)
profile: 
	Profiling\obj\Debug\Profiling.exe < data.txt

# (vypíše nápovědu s popisem, co je potřeba udělat před spuštěním programu)
help: 
	@echo "build and run program run: 'make run/all'"
	@echo "run profiling with input data in \repo\src\data.txt run 'make profile'"
	@echo "create .zip folder of project run 'make pack'"
	@echo "remove unnecessary files run 'make clean'"
	@echo "install file location \install\setup.exe"
	@echo "more info about program see \doc\dokumentce.pdf"
	@echo "if any questions/propositions contact xoleks00@stud.fit.vutbr.cz or xfindr00@stud.fit.vutbr.cz or xkromp00@stud.fit.vutbr.cz or xkruzi04@stud.fit.vutbr.cz"
