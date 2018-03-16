DELIMITER |
CREATE TRIGGER Add_Cham AFTER INSERT ON Chambre FOR EACH ROW
BEGIN
update TypeCham set NbDispo=(select count(NoCham) from Chambre where Chambre.CodTypChan=NEW.CodTypChan and Etat=1) where TypeCham.CodTypChan=NEW.CodTypChan;
END |
DELIMITER ;