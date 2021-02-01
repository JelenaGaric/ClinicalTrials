
--SELECT [Condition], [NCTId]
--FROM [ProtocolSection]
--join [IdentificationModule] on [ProtocolSection].IdentificationModuleId = [IdentificationModule].Id
--join [ConditionsModule] on [ProtocolSection].ConditionsModuleId = [ConditionsModule].Id
--join [ConditionList] on [ConditionsModule].ConditionListId = [ConditionList].Id
--where Condition like '%breast%cancer%' 
--WHERE contains([Condition], 'cancer') 

--ovarian, lung, prostate, kidney, breast, bladder

--CREATE FUNCTION dbo.GetSunburstData( @term VARCHAR(50) )
--RETURNS TABLE
--AS
--RETURN 
--SELECT COUNT(*) as 'Count'
--	FROM [ProtocolSection]
--	join [IdentificationModule] on [ProtocolSection].IdentificationModuleId = [IdentificationModule].Id
--	join [ConditionsModule] on [ProtocolSection].ConditionsModuleId = [ConditionsModule].Id
--	join [ConditionList] on [ConditionsModule].ConditionListId = [ConditionList].Id
--	WHERE [Condition] LIKE '%' + @term + '%';
