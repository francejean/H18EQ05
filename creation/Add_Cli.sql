CREATE TRIGGER Add_Cli
ON Client
AFTER INSERT
AS
update Client set SoldeDu=0 from Client as c join inserted as i on c.IdCli=i.IdCli where c.IdCli=i.IdCli;