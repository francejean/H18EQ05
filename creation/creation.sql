drop database if exists test; --changer le nom de la base de donnée
create database test;
use test;

create table Client
(
	IdCli int not NULL auto_increment,
	Nom varchar(25) NULL,
	Adresse varchar(25) NULL,
	Telephone varchar(10) NULL,
	NoCarte varchar(16) NULL,
	TypeCarte varchar(15) NULL,
	DatExp date NULL,
	SoldeDu decimal(12,2) NULL,
	primary key(IdCli)
)
ENGINE=INNODB;

create table TypeCham
(
	CodTypChan varchar(2) not NULL,
	DescTyp varchar(25) NULL,
	NbDispo int(3) NULL,
	primary key(CodTypChan)
)
ENGINE=INNODB;

create table Localisation
(
	CodLoc varchar(2) not NULL,
	DescLoc varchar(25) NULL,
	primary key(CodLoc)
)
ENGINE=INNODB;

create table Commodite
(
	CodCom varchar(2) not NULL,
	DescCom varchar(25) NULL,
	primary key(CodCom)
)
ENGINE=INNODB;

create table TypeTRX
(
	CodTypTrx varchar(2) not NULL,
	DescTrx varchar(25) NULL,
	Nature varchar(2) NULL,
	primary key(CodTypTrx)
)
ENGINE=INNODB;

create table Chambre
(
	NoCham varchar(3) not NULL,
	Etage varchar(2) NULL,
	Prix decimal(5,2) NULL,
	Etat tinyint NULL,
	Memo varchar(max) NULL,
	CodLoc varchar(2) NULL,
	CodTypChan varchar(2) NULL,
	primary key(NoCham),
	foreign key(CodLoc) references Localisation(CodLoc),
	foreign key(CodTypChan) references TypeCham(CodTypChan)
)
ENGINE=INNODB;

create table Reservation
(
	IdReser int not NULL auto_increment,
	DateReser date NULL,
	DateDebut date NULL,
	DateFin date NULL,
	IdCli int NULL,
	primary key(IdReser),
	foreign key(IdCli) references Client(IdCli)
)
ENGINE=INNODB;

create table Ayant
(
	NoCham varchar(3) NULL,
	CodCom varchar(2) NULL,
	foreign key(NoCham) references Chambre(NoCham),
	foreign key(CodCom) references Commodite(CodCom)
)
ENGINE=INNODB;

create table De
(
	Attribuee tinyint NULL,
	IdReser int NULL,
	NoCham varchar(3) NULL,
	foreign key(IdReser) references Reservation(IdReser),
	foreign key(NoCham) references Chambre(NoCham)
)
ENGINE=INNODB;

create table Arrive
(
	IdArrive int not NULL auto_increment,
	DateArrive date NULL,
	IdCli int NULL,
	IdReser int NULL,
	NoCham varchar(3) NULL,
	primary key(IdArrive),
	foreign key(IdCli) references Client(IdCli),
	foreign key(IdReser) references Reservation(IdReser),
	foreign key(NoCham) references Chambre(NoCham)
)
ENGINE=INNODB;

create table Depart
(
	IdDepart int not NULL auto_increment,
	DateDepart date NULL,
	ConfirmerPar varchar(2) NULL,
	IdReser int NULL,
	NoCham varchar(3) NULL,
	IdCli int NULL,
	primary key(IdDepart),
	foreign key(IdReser) references Reservation(IdReser),
	foreign key(NoCham) references Chambre(NoCham),
	foreign key(IdCli) references Client(IdCli)
)
ENGINE=INNODB;

create table TRX
(
	IdTrx int not NULL auto_increment,
	DateTrx date NULL,
	MontantTrx decimal(10,2) NULL,
	Reportee tinyint NULL,
	CodTypTrx varchar(2) NULL,
	IdReser int NULL,
	NoCham varchar(3) NULL,
	IdCli int NULL,
	primary key(IdTrx),
	foreign key(CodTypTrx) references TypeTRX(CodTypTrx),
	foreign key(IdReser) references Reservation(IdReser),
	foreign key(NoCham) references Chambre(NoCham),
	foreign key(IdCli) references Client(IdCli)
)
ENGINE=INNODB;