--insertion chambre
--insert into Chambre values ('','','','','','','');
insert into Chambre values ('555','05',203.99,1,'Grande chambre pour la famille','SM','ST');

--insertion client
--insert into Client (Nom,Adresse,Telephone,NoCarte,TypeCarte,DatExp,SoldeDu) values ('','','','','','','');
insert into Client (Nom,Adresse,Telephone,NoCarte,TypeCarte,DatExp,SoldeDu) values ('Réjean','5915 Jean-Cormier','4189999999','255248963574','Mastercard',getdate()+200,550);

insert into Reservation (DateReser,DateDebut,DateFin,IdCli) values (getdate()-50,getdate()-42,getdate()-1,'2');
insert into Reservation (DateReser,DateDebut,DateFin,IdCli) values (getdate()+22,getdate()+27,getdate()-1,'3');

--insertion de
--insert into De values ('','','');
insert into De values (0,'1','201');
insert into De values (1,'1','110');
insert into De values (0,'2','201');
insert into De values (1,'2','555');
insert into De values (0,'3','405');