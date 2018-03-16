CREATE TRIGGER B_Del_Cham
ON Chambre
INSTEAD OF DELETE
AS
BEGIN
delete from Ayant where Ayant.NoCham in (select NoCham from deleted);
delete from Chambre where Chambre.NoCham in (select NoCham from deleted);
END