CREATE FUNCTION dbo.GetCountriesForTerm( @term VARCHAR(50) )
RETURNS TABLE
AS
RETURN 
    SELECT [LocationCountry], count(*) as NUM
	FROM [ClinicalTrials].[dbo].[Study]
	INNER JOIN [ClinicalTrials].[dbo].[ProtocolSection]
			ON [ClinicalTrials].[dbo].[Study].[ProtocolSectionId] = [ProtocolSection].[Id]
		INNER JOIN [ClinicalTrials].[dbo].[ContactsLocationsModule]
			ON [ClinicalTrials].[dbo].[ProtocolSection].[ContactsLocationsModuleId] = [ContactsLocationsModule].[Id]
		INNER JOIN [ClinicalTrials].[dbo].[Location]
			ON [ClinicalTrials].[dbo].[ContactsLocationsModule].[LocationListId] = [Location].[LocationListId]
		INNER JOIN [ClinicalTrials].[dbo].[DerivedSection]
			ON [ClinicalTrials].[dbo].[Study].[DerivedSectionId] = [DerivedSection].[Id]
		INNER JOIN [ClinicalTrials].[dbo].[ConditionBrowseModule]
			ON [ClinicalTrials].[dbo].[DerivedSection].[ConditionBrowseModuleId] = [ConditionBrowseModule].[Id]
		INNER JOIN [ClinicalTrials].[dbo].[ConditionMesh]
			ON [ClinicalTrials].[dbo].[ConditionBrowseModule].[ConditionMeshListId] = [ConditionMesh].[ConditionMeshListId]
	WHERE  [ClinicalTrials].[dbo].[ConditionMesh].[ConditionMeshTerm] LIKE '%' + @term + '%'
	GROUP BY [LocationCountry];


	CREATE FUNCTION dbo.GetCoordinatesForTerm( @term VARCHAR(50) )
RETURNS TABLE
AS
RETURN 
    SELECT [ClinicalTrials].[dbo].[Location].[LocationCity], [lat], [lng], count(*) as NUM
	FROM [ClinicalTrials].[dbo].[Study]
	INNER JOIN [ClinicalTrials].[dbo].[ProtocolSection]
		ON [ClinicalTrials].[dbo].[Study].[ProtocolSectionId] = [ProtocolSection].[Id]
	INNER JOIN [ClinicalTrials].[dbo].[ContactsLocationsModule]
		ON [ClinicalTrials].[dbo].[ProtocolSection].[ContactsLocationsModuleId] = [ContactsLocationsModule].[Id]
	INNER JOIN [ClinicalTrials].[dbo].[Location]
		ON [ClinicalTrials].[dbo].[ContactsLocationsModule].[LocationListId] = [Location].[LocationListId]
	INNER JOIN [ClinicalTrials].[dbo].[DerivedSection]
		ON [ClinicalTrials].[dbo].[Study].[DerivedSectionId] = [DerivedSection].[Id]
	INNER JOIN [ClinicalTrials].[dbo].[ConditionBrowseModule]
		ON [ClinicalTrials].[dbo].[DerivedSection].[ConditionBrowseModuleId] = [ConditionBrowseModule].[Id]
	INNER JOIN [ClinicalTrials].[dbo].[ConditionMesh]
		ON [ClinicalTrials].[dbo].[ConditionBrowseModule].[ConditionMeshListId] = [ConditionMesh].[ConditionMeshListId]
	INNER JOIN  [ClinicalTrials].[dbo].[CityCoordinates]
		ON [ClinicalTrials].[dbo].[Location].[LocationCity] = [CityCoordinates].[LocationCity]
	WHERE  [ClinicalTrials].[dbo].[ConditionMesh].[ConditionMeshTerm] LIKE '%' + @term + '%'
	GROUP BY [ClinicalTrials].[dbo].[Location].[LocationCity], [lat], [lng];