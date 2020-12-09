--Підрахунок кількості квитків, придбаних покупцем
CREATE PROCEDURE [CountTickets]
	@idBuyer INT
AS
SELECT
	COUNT ([tkt_id])
FROM [dbo].[Ticket]
WHERE
		[tkt_br_id_FK] = @idBuyer;