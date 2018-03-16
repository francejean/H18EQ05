DELIMITER |
CREATE TRIGGER B_Del_Cham BEFORE DELETE ON Chambre FOR EACH ROW
BEGIN
delete from Ayant where Ayant.NoCham=old.NoCham;
END |
DELIMITER ;