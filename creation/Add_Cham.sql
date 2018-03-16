CREATE TRIGGER Add_Cham
ON Chambre
AFTER INSERT
AS
BEGIN
update TypeCham set NbDispo=(select count(c.NoCham) from Chambre as c join inserted as i on c.CodTypChan=i.CodTypChan where c.CodTypChan=i.CodTypChan and c.Etat=1) 
from TypeCham as t join inserted as i on t.CodTypChan=i.CodTypChan where t.CodTypChan=i.CodTypChan;
END