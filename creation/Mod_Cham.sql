DELIMITER |
CREATE TRIGGER Mod_Cham ON Chambre
AFTER UPDATE
AS BEGIN
update TypeCham set NbDispo=(select count(NoCham) from Chambre where Chambre.CodTypChan=OLD.CodTypChan and Etat=1) where TypeCham.CodTypChan=OLD.CodTypChan;
update TypeCham set NbDispo=(select count(NoCham) from Chambre where Chambre.CodTypChan=NEW.CodTypChan and Etat=1) where TypeCham.CodTypChan=NEW.CodTypChan;
END |
DELIMITER ;