CREATE TRIGGER Mod_Cham
ON Chambre
AFTER UPDATE
AS BEGIN
update TypeCham set NbDispo=(select count(c.NoCham) from Chambre as c join deleted as d on c.CodTypChan=d.CodTypChan where c.CodTypChan=d.CodTypChan and c.Etat=1)
from TypeCham as t join deleted as d on t.CodTypChan=d.CodTypChan where t.CodTypChan=d.CodTypChan;
update TypeCham set NbDispo=(select count(c.NoCham) from Chambre as c join inserted as i on c.CodTypChan=i.CodTypChan where c.CodTypChan=i.CodTypChan and c.Etat=1)
from TypeCham as t join inserted as i on t.CodTypChan=i.CodTypChan where t.CodTypChan=i.CodTypChan;
END