DELIMITER |
CREATE TRIGGER A_Del_Cham AFTER DELETE ON Chambre FOR EACH ROW
BEGIN
update TypeCham set NbDispo=(select count(NoCham) from Chambre where Chambre.CodTypChan=OLD.CodTypChan and Etat=1) where TypeCham.CodTypChan=OLD.CodTypChan;
END |
DELIMITER ;