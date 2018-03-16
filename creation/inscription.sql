--insertion type chambre
--insert into TypeCham values ('','','');
insert into TypeCham values ('1J','1 Lit Jumeau','');
insert into TypeCham values ('2J','2 Lits Jumeaux','');
insert into TypeCham values ('1D','1 Lit Double','');
insert into TypeCham values ('2D','2 Lits Double','');
insert into TypeCham values ('LQ','Lit Queen','');
insert into TypeCham values ('LK','Lit King','');
insert into TypeCham values ('ST','Suite','');
insert into TypeCham values ('SR','Salle Réception','');

--insertion commodite
--insert into Commodite values ('','');
insert into Commodite values ('AS','Standards, Rien');
insert into Commodite values ('BA','Avec Balcon');
insert into Commodite values ('BT','Avec Bain Tourbillon');
insert into Commodite values ('CC','Chambre Communicante');
insert into Commodite values ('IN','Internet');
insert into Commodite values ('MB','Mini Bar');
insert into Commodite values ('HP','Handicape');
insert into Commodite values ('NF','Non Fumeur');

--insertion localisation
--insert into Localisation values ('','');
insert into Localisation values ('AR','Arrière');
insert into Localisation values ('AS','Près de Ascenseur');
insert into Localisation values ('AV','Avant');
insert into Localisation values ('VM','Vue sur la Mer');
insert into Localisation values ('SM','Près de la Salle à Manger');

--insertion client
--insert into Client (Nom,Adresse,Telephone,NoCarte,TypeCarte,DatExp,SoldeDu) values ('','','','','','','');
insert into Client (Nom,Adresse,Telephone,NoCarte,TypeCarte,DatExp,SoldeDu) values ('Beliveau','28','8191112222','1111222233334444','visa','',0);
insert into Client (Nom,Adresse,Telephone,NoCarte,TypeCarte,DatExp,SoldeDu) values ('Laforme','50','8193334444','5555666677778888','mastercard','',0);

--insertion type trx
--insert into TypeTRX values ('','','');
insert into TypeTRX values ('01','Prix chambre','DB');
insert into TypeTRX values ('02','Lit additionnel','DB');
insert into TypeTRX values ('10','Telephone interrubain','DB');
insert into TypeTRX values ('21','Photocopie','DB');
insert into TypeTRX values ('22','Internet','DB');
insert into TypeTRX values ('30','Restaurant','DB');
insert into TypeTRX values ('31','Bar terrasse','DB');
insert into TypeTRX values ('50','Depot argent','CR');
insert into TypeTRX values ('60','Paiement','CR');

--insertion chambre
--insert into Chambre values ('','','','','','','');
insert into Chambre values ('201','02',75.25,1,'Chambre branché pour non fumeur','AR','LK');
insert into Chambre values ('405','04',96.73,1,'Chambre VIP','VM','ST');
insert into Chambre values ('110','01',50.93,0,'Chambre parfaite pour handicapé','AS','1D');

--insertion reservation
--insert into Reservation (DateReser,DateDebut,DateFin,IdCli) values (getdate(),getdate(),getdate(),'');
insert into Reservation (DateReser,DateDebut,DateFin,IdCli) values (getdate()-22,getdate()-15,getdate()-1,'1');

--insertion de
--insert into De values ('','','');
insert into De values (1,'1','405');

--insertion ayant
--insert into Ayant values ('','');
insert into Ayant values ('201','NF');
insert into Ayant values ('201','IN');
insert into Ayant values ('201','BA');
insert into Ayant values ('405','BT');
insert into Ayant values ('405','MB');
insert into Ayant values ('405','IN');
insert into Ayant values ('405','BA');
insert into Ayant values ('110','HP');

--insertion arrive
--insert into Arrive (DateArrive,IdCli,IdReser,NoCham) values (getdate(),'','','');
insert into Arrive (DateArrive,IdCli,IdReser,NoCham) values (getdate()-15,'1','1','405');

--insertion depart !!Pas de depart sans arrive!!
--insert into Depart (DateDepart,ConfirmerPar,IdReser,NoCham,IdCli) values (getdate(),'','','','');
insert into Depart (DateDepart,ConfirmerPar,IdReser,NoCham,IdCli) values (getdate()-1,'AB','1','405','1');

--insertion trx
--insert into TRX (DateTrx,MontantTrx,Reportee,CodTypTrx,IdReser,NoCham,IdCli) values (getdate(), , ,'','','','');
insert into TRX (DateTrx,MontantTrx,Reportee,CodTypTrx,IdReser,NoCham,IdCli) values (getdate()-15,96.73,1,'01','1','405','1');
insert into TRX (DateTrx,MontantTrx,Reportee,CodTypTrx,IdReser,NoCham,IdCli) values (getdate()-1,10.50,1,'22','1','405','1');
insert into TRX (DateTrx,MontantTrx,Reportee,CodTypTrx,IdReser,NoCham,IdCli) values (getdate()-1,107.23,1,'60','1','405','1');