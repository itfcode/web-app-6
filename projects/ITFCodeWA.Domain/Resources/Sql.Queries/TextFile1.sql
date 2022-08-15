/****** Script for SelectTopNRows command from SSMS  ******/
USE [ITFCodeWANet6]

SELECT TOP (20)
	 [Head].[DateMonth] as DateMonth,
	 CAST(Min([Rows].[Weight]) AS decimal(12,1)) AS [Min],
	 CAST(Max([Rows].[Weight]) AS decimal(12,1)) AS [Max],
	 CAST(Avg([Rows].[Weight]) AS decimal(12,1)) AS [Avg]
FROM
	[dbo].[WeightRegistrator] AS [Head]
	INNER JOIN [dbo].[WeightRegistratorRows] AS [Rows]
		ON [Head].[WeightRegistratorId] = [Rows].[DocumentId]
GROUP BY 
	DateMonth
ORDER BY 
	DateMonth DESC
	

