SELECT NCTId
FROM [ClinicalTrials].[dbo].[JSONStudy]   
WHERE contains([JSON], 'radiotherapy') 
/*freetext*/