
library(date)
require(data.table)
library(lubridate)
library(xts)

check <- function() {
	

	############### study type by year
	myData2 <- read.csv("./RData/years.csv", header=TRUE)

	##
	StudytypeExpandedAccesspol <- lm(myData2$Expanded.Access  ~ poly(c(1:length(myData2$X)),2 ))
	write.csv(predict(StudytypeExpandedAccesspol), "./RData/regressionExpandedAccessYearsPol.csv")
	StudytypeExpandedAccesslin <- lm(myData2$Expanded.Access  ~ c(1:length(myData2$X)))
	write.csv(predict(StudytypeExpandedAccesslin ), "./RData/regressionExpandedAccessYearsLin.csv")

	plot(x=c(1:length(myData2$X)), y=myData2$Expanded.Access  ,main = "Number of clinical trials",xlab = "year", ylab = "number of clinical trials")
	lines(c(1:length(myData2$X)), predict(StudytypeExpandedAccesspol), type="l", col="red1", lwd=2)

	##
	StudytypeInterventionallin <- lm(myData2$Interventional  ~ c(1:length(myData2$X)) )
	write.csv(predict(StudytypeInterventionallin), "./RData/regressionInterventionalYearsLin.csv")
	StudytypeInterventionalpol <- lm(myData2$Interventional  ~ poly(c(1:length(myData2$X)),2 ) )
	write.csv(predict(StudytypeInterventionalpol ), "./RData/regressionInterventionalYearsPol.csv")

	plot(x=c(1:length(myData2$X)), y=myData2$Interventional  ,main = "Number of clinical trials",xlab = "year", ylab = "number of clinical trials")
	lines(c(1:length(myData2$X)), predict(StudytypeInterventionallin), type="l", col="red1", lwd=2)

	##
	StudytypeObservationalpol <- lm(myData2$Observational  ~ poly(c(1:length(myData2$X)),2 ))
	write.csv(predict(StudytypeObservationalpol), "./RData/regressionObservationalYearsPol.csv")
	StudytypeObservationallin <- lm(myData2$Observational  ~ c(1:length(myData2$X)))
	write.csv(predict(StudytypeObservationallin ), "./RData/regressionObservationalYearsLin.csv")

	plot(x=c(1:length(myData2$X)), y=myData2$Observational  ,main = "Number of clinical trials",xlab = "year", ylab = "number of clinical trials")
	lines(c(1:length(myData2$X)), predict(StudytypeObservationalpol), type="l", col="red1", lwd=2)

	############# study type by days
	myData2 <- read.csv("C:/Downloads/days.csv", header=TRUE)

	####
	StudytypeExpandedAccesspol <- lm(myData2$Expanded.Access  ~ poly(c(1:length(myData2$X)),2 ))
	write.csv(predict(StudytypeExpandedAccesspol), "./RData/regressionExpandedAccessDaysPol.csv")

	StudytypeExpandedAccesslin <- lm(myData2$Expanded.Access  ~ c(1:length(myData2$X)))
	write.csv(predict(StudytypeExpandedAccesslin), "./RData/regressionExpandedAccessDaysLin.csv")

	plot(x=c(1:length(myData2$X)), y=myData2$Expanded.Access  ,main = "Number of clinical trials",xlab = "days", ylab = "number of clinical trials")
	lines(c(1:length(myData2$X)), predict(StudytypeExpandedAccesspol), type="l", col="red1", lwd=2)

	####
	StudytypeInterventionallin <- lm(myData2$Interventional  ~ c(1:length(myData2$X)) )
	write.csv(predict(StudytypeInterventionallin), "./RData/regressionInterventionalDaysLin.csv")
	StudytypeInterventionalpol <- lm(myData2$Interventional  ~ poly(c(1:length(myData2$X)),2 ))
	write.csv(predict(StudytypeInterventionalpol), "./RData/regressionInterventionalDaysPol.csv")

	plot(x=c(1:length(myData2$X)), y=myData2$Interventional  ,main = "Number of clinical trials",xlab = "days", ylab = "number of clinical trials")
	lines(c(1:length(myData2$X)), predict(StudytypeInterventionallin), type="l", col="red1", lwd=2)

	####
	StudytypeObservationalpol <- lm(myData2$Observational  ~ poly(c(1:length(myData2$X)),2 ))
	write.csv(predict(StudytypeObservationalpol), "./RData/regressionObservationalDaysPol.csv")
	StudytypeObservationallin <- lm(myData2$Observational  ~ c(1:length(myData2$X)))
	write.csv(predict(StudytypeObservationallin ), "./RData/regressionObservationalDaysLin.csv")

	plot(x=c(1:length(myData2$X)), y=myData2$Observational  ,main = "Number of clinical trials",xlab = "days", ylab = "number of clinical trials")
	lines(c(1:length(myData2$X)), predict(StudytypeObservationalpol), type="l", col="red1", lwd=2)

	################### study type by months
	myData2 <- read.csv("C:/Downloads/months.csv", header=TRUE)

	####
	StudytypeExpandedAccesspol <- lm(myData2$Expanded.Access  ~ poly(c(1:length(myData2$X)),2 ))
	write.csv(predict(StudytypeExpandedAccesspol), "./RData/regressionExpandedAccessMonthsPol.csv")
	StudytypeExpandedAccesslin <- lm(myData2$Expanded.Access  ~ c(1:length(myData2$X)))
	write.csv(predict(StudytypeExpandedAccesslin), "./RData/regressionExpandedAccessMonthsLin.csv")

	plot(x=c(1:length(myData2$X)), y=myData2$Expanded.Access  ,main = "Number of clinical trials",xlab = "months", ylab = "number of clinical trials")
	lines(c(1:length(myData2$X)), predict(StudytypeExpandedAccesspol), type="l", col="red1", lwd=2)

	##
	StudytypeInterventionallin <- lm(myData2$Interventional  ~ c(1:length(myData2$X)) )
	write.csv(predict(StudytypeInterventionallin), "./RData/regressionInterventionalMonthsLin.csv")
	
	StudytypeInterventionalpol <- lm(myData2$Interventional  ~ poly(c(1:length(myData2$X)),2))
	write.csv(predict(StudytypeInterventionalpol ), "./RData/regressionInterventionalMonthsPol.csv")

	plot(x=c(1:length(myData2$X)), y=myData2$Interventional  ,main = "Number of clinical trials",xlab = "months", ylab = "number of clinical trials")
	lines(c(1:length(myData2$X)), predict(StudytypeInterventionallin), type="l", col="red1", lwd=2)

	##
	StudytypeObservationalpol <- lm(myData2$Observational  ~ poly(c(1:length(myData2$X)),2 ))
	write.csv(predict(StudytypeObservationalpol), "./RData/regressionObservationalMonthsPol.csv")
	StudytypeObservationallin <- lm(myData2$Observational  ~ c(1:length(myData2$X)))
	write.csv(predict(StudytypeObservationallin ), "./RData/regressionObservationalMonthsLin.csv")

	plot(x=c(1:length(myData2$X)), y=myData2$Observational  ,main = "Number of clinical trials",xlab = "months", ylab = "number of clinical trials")
	lines(c(1:length(myData2$X)), predict(StudytypeObservationalpol), type="l", col="red1", lwd=2)

	################### study type by quarter-year
	myData2 <- read.csv("C:/Downloads/quarters.csv", header=TRUE)

	##
	StudytypeExpandedAccesslin <- lm(myData2$Expanded.Access  ~ c(1:length(myData2$X)) )
	write.csv(predict(StudytypeExpandedAccesslin), "./RData/regressionExpandedAccessQLin.csv")
	StudytypeExpandedAccesspol <- lm(myData2$Expanded.Access  ~ poly(c(1:length(myData2$X)),2 ) )
	write.csv(predict(StudytypeExpandedAccesspol ), "./RData/regressionExpandedAccessQPol.csv")

	plot(x=c(1:length(myData2$X)), y=myData2$Expanded.Access  ,main = "Number of clinical trials",xlab = "q-year", ylab = "number of clinical trials")
	lines(c(1:length(myData2$X)), predict(StudytypeExpandedAccesslin), type="l", col="red1", lwd=2)

	##
	StudytypeInterventionallin <- lm(myData2$Interventional  ~ c(1:length(myData2$X)) )
	write.csv(predict(StudytypeInterventionallin), "./RData/regressionInterventionalQLin.csv")
	StudytypeInterventionalpol <- lm(myData2$Interventional  ~ poly(c(1:length(myData2$X)),2 ) )
	write.csv(predict(StudytypeInterventionalpol ), "./RData/regressionInterventionalQPol.csv")

	plot(x=c(1:length(myData2$X)), y=myData2$Interventional  ,main = "Number of clinical trials",xlab = "q-year", ylab = "number of clinical trials")
	lines(c(1:length(myData2$X)), predict(StudytypeInterventionallin), type="l", col="red1", lwd=2)

	##
	StudytypeObservationallin <- lm(myData2$Observational  ~ c(1:length(myData2$X)) )
	write.csv(predict(StudytypeObservationalpol), "./RData/regressionObservationalQLin.csv")
	StudytypeObservationalpol <- lm(myData2$Observational  ~ poly(c(1:length(myData2$X)),2 ) )
	write.csv(predict(StudytypeObservationalpol ), "./RData/regressionObservationalQPol.csv")

	#plot(x=c(1:length(myData2$X)), y=myData2$Observational  ,main = "Number of clinical trials",xlab = "q-year", ylab = "number of clinical trials")
	#lines(c(1:length(myData2$X)), predict(StudytypeObservationalpol), type="l", col="red1", lwd=2)


	#summary(StudytypeObservationalpol)

	return("Ok")
}

check()
  