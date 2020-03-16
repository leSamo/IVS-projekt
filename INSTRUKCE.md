# IVS projekt - Kalkulačka
2019/20 tím Orient Express

-----
## Práca s git-om
### Prvé nastavenie
#### Potrebné nástroje
Visual Studio má podporu pre git, takže zmeny sa dajú vykonávať v rámci neho, ale na nastavenie repozitáru a opravu chýb je potrebný shell, odporúčam Git Bash.
#### Nastavenie prihlasovacích údajov (rovnakých ako na github)  
`git config --global user.name "John Doe"`  
`git config --global user.email johndoe@example.com`  
#### Stiahnutie projektu
`git clone https://github.com/leSamo/IVS-projekt.git`

-----
### Vykonávanie zmien
#### Stiahnutie najnovších informácií o zmenách
`git fetch`
#### Zistenie stavu
`git status`
#### Zistenie posledných zmien
`git log`
#### Stiahnutie najnovšej verzie
`git pull`
#### Pridanie súborov do prípravného priestoru
`git add [nazov_suboru]`
#### Odobratie súborov z prípravného priestoru
`git rm [nazov_suboru]`
#### Vykonanie zmien z prípravného priestoru
`git commit -m "správa čo je v tejto zmene zahrnuté"`
#### Odoslanie mojich zmien na server
`git push`
