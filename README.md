# studis
Studis za TPO

1. Namestitve za mysql in VS  
https://dev.mysql.com/downloads/connector/net/  
http://dev.mysql.com/downloads/windows/visualstudio/

2. Baza  
my_aspnet_applications: seznam aplikacij, imamo samo eno  
my_aspnet_membership: glavna tabela uporabnikov za login  
my_aspnet_roles: vse role za na�o aplikacijo  
my_aspnet_users: �e prav razumem ta tabela obstaja zato, da lahko ima� ve� uporabnikov z istim imenom �e ima� ve� aplikacij, FK userID v membership
my_aspnet_usersinroles: pove�e uporabnika z rolo

Torej, vse tabele ki se navezujejo na nekega uporabnika (npr �tudent) povezujemo z FK na tabelo my_aspnet_users


3. Vstavljanje in iskanje po bazi z Entity Framework 6   
http://www.entityframeworktutorial.net  
Bistvo je da ima� nek globalen kontekst (pri nas se imenuje Studis), ki ga definira� kot nek private v kontrolerju  
ali pa uporabi� use() sintakso. Nad tem kontekstom se potem vr�ijo operacije SQL.  
Lahko pi�e� direkt SQL, uporablja� LINQ ali pa Entity SQL, glej poglavje "Querying with EDM"

4. Obrazci  
Za primer glej UserModels.cs.. za vsak obrazec naredi� class kjer definira� vse spremenljivke in validatorje.  
Nato v View (npr Login.cs) binda� na ta model in vse se avtomagi�no samo validira.

5. Vloge in pravice  
Ro�no sem vstavil v bazo vloge: �tudent, Skrbnik, Profesor, Referent  
Vloge so definirane v my_apsnet_roles in povezane na uporabnike my_aspnet_usersinroles  
�e ho�ete omejiti nek kontroler na dolo�eno rolo uporabite nad kontrolerjem: [Authorize(Roles = "�tudent")] ipd  
Simpl zadeva. Lahklo omeji� tudi na dolo�enega userja ali samo na dolo�eno akcijo kontrolerja.