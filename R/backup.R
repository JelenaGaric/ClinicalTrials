
library(date)
require(data.table)
library(lubridate)
library(xts)
check <- function() {
	

	myData <- read.csv("C:/Downloads/NCT0000xxxx-NCT0453xxxx.csv", header=TRUE)

	study_first_submitted <- as.Date(myData$StudyFirstSubmitDate,format = "%m/%d/%Y")
	study_type <- factor(myData$StudyType, order = TRUE, levels =c
						 ('Expanded Access','Interventional','Observational'))

	tblday <- table(study_first_submitted,study_type)
	write.csv(tblday, "C:/Downloads/days.csv")



	########### study type by months
	study_first_submitted_month   <- as.yearmon(study_first_submitted)
	tblmonth <- table(study_first_submitted_month,study_type)
	write.csv(tblmonth, "C:/Downloads/months.csv")


	########### study type by quarter-year
	study_first_submitted_Q   <- as.yearqtr(study_first_submitted)
	tblQ <- table(study_first_submitted_Q,study_type)
	write.csv(tblQ, "C:/Downloads/typeQ.csv")


	########### study type by years
	study_first_submitted_year   <- year(as.IDate(study_first_submitted, "%m/%d/%Y"))
	tblyear <- table(study_first_submitted_year,study_type)
	write.csv(tblyear, "C:/Downloads/typey.csv")
	return("Ok")
}

check()
  