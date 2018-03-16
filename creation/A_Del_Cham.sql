CREATE TRIGGER A_Del_Cham
ON Chambre
AFTER DELETE
AS
BEGIN
update TypeCham set NbDispo=(select count(c.NoCham) from Chambre as c join deleted as d on c.CodTypChan=d.CodTypChan where c.CodTypChan=d.CodTypChan and c.Etat=1)
from TypeCham as t join deleted as d on t.CodTypChan=d.CodTypChan where t.CodTypChan=d.CodTypChan;
END