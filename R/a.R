
library(date)
require(data.table)
library(lubridate)
library(xts)

check <- function() {
	
	############### study type by year
	myData2 <- read.csv("C:/Downloads/years.csv", header=TRUE)

	head(myData2)
	##
	StudytypeExpandedAccesspol <- lm(myData2$Expanded.Access  ~ poly(c(1:length(myData2$X)),2 ))
	write.csv(predict(StudytypeExpandedAccesspol), "C:/Downloads/regresijaExpandedAccessYears.csv")
	plot(x=c(1:length(myData2$X)), y=myData2$Expanded.Access  ,main = "Number of clinical trials",xlab = "year", ylab = "number of clinical trials")
	lines(c(1:length(myData2$X)), predict(StudytypeExpandedAccesspol), type="l", col="red1", lwd=2)

	##
	StudytypeInterventionallin <- lm(myData2$Interventional  ~ c(1:length(myData2$X)) )
	write.csv(predict(StudytypeInterventionallin), "C:/Downloads/regresijaInterventionalYears.csv")
	plot(x=c(1:length(myData2$X)), y=myData2$Interventional  ,main = "Number of clinical trials",xlab = "year", ylab = "number of clinical trials")
	lines(c(1:length(myData2$X)), predict(StudytypeInterventionallin), type="l", col="red1", lwd=2)

	##
	StudytypeObservationalpol <- lm(myData2$Observational  ~ poly(c(1:length(myData2$X)),2 ))
	write.csv(predict(StudytypeObservationalpol), "C:/Downloads/regresijaObservationalYears.csv")
	plot(x=c(1:length(myData2$X)), y=myData2$Observational  ,main = "Number of clinical trials",xlab = "year", ylab = "number of clinical trials")
	lines(c(1:length(myData2$X)), predict(StudytypeObservationalpol), type="l", col="red1", lwd=2)

	############# study type by days
	myData2 <- read.csv("C:/Downloads/days.csv", header=TRUE)

	##
	StudytypeExpandedAccesspol <- lm(myData2$Expanded.Access  ~ poly(c(1:length(myData2$X)),2 ))
	write.csv(predict(StudytypeExpandedAccesspol), "C:/Downloads/regresijaExpandedAccessDays.csv")
	plot(x=c(1:length(myData2$X)), y=myData2$Expanded.Access  ,main = "Number of clinical trials",xlab = "days", ylab = "number of clinical trials")
	lines(c(1:length(myData2$X)), predict(StudytypeExpandedAccesspol), type="l", col="red1", lwd=2)

	##
	StudytypeInterventionallin <- lm(myData2$Interventional  ~ c(1:length(myData2$X)) )
	write.csv(predict(StudytypeInterventionallin), "C:/Downloads/regresijaInterventionalDays.csv")
	plot(x=c(1:length(myData2$X)), y=myData2$Interventional  ,main = "Number of clinical trials",xlab = "days", ylab = "number of clinical trials")
	lines(c(1:length(myData2$X)), predict(StudytypeInterventionallin), type="l", col="red1", lwd=2)

	##
	StudytypeObservationalpol <- lm(myData2$Observational  ~ poly(c(1:length(myData2$X)),2 ))
	write.csv(predict(StudytypeObservationalpol), "C:/Downloads/regresijaObservationalDays.csv")
	plot(x=c(1:length(myData2$X)), y=myData2$Observational  ,main = "Number of clinical trials",xlab = "days", ylab = "number of clinical trials")
	lines(c(1:length(myData2$X)), predict(StudytypeObservationalpol), type="l", col="red1", lwd=2)


	################### study type by months
	myData2 <- read.csv("C:/Downloads/months.csv", header=TRUE)


	##
	StudytypeExpandedAccesspol <- lm(myData2$Expanded.Access  ~ poly(c(1:length(myData2$X)),2 ))
	write.csv(predict(StudytypeExpandedAccesspol), "C:/Downloads/regresijaExpandedAccessMonths.csv")
	plot(x=c(1:length(myData2$X)), y=myData2$Expanded.Access  ,main = "Number of clinical trials",xlab = "months", ylab = "number of clinical trials")
	lines(c(1:length(myData2$X)), predict(StudytypeExpandedAccesspol), type="l", col="red1", lwd=2)

	##
	StudytypeInterventionallin <- lm(myData2$Interventional  ~ c(1:length(myData2$X)) )
	write.csv(predict(StudytypeInterventionallin), "C:/Downloads/regresijaInterventionalMonths.csv")
	plot(x=c(1:length(myData2$X)), y=myData2$Interventional  ,main = "Number of clinical trials",xlab = "months", ylab = "number of clinical trials")
	lines(c(1:length(myData2$X)), predict(StudytypeInterventionallin), type="l", col="red1", lwd=2)

	##
	StudytypeObservationalpol <- lm(myData2$Observational  ~ poly(c(1:length(myData2$X)),2 ))
	write.csv(predict(StudytypeObservationalpol), "C:/Downloads/regresijaObservationalMonths.csv")
	plot(x=c(1:length(myData2$X)), y=myData2$Observational  ,main = "Number of clinical trials",xlab = "months", ylab = "number of clinical trials")
	lines(c(1:length(myData2$X)), predict(StudytypeObservationalpol), type="l", col="red1", lwd=2)


	################### study type by quarter-year
	myData2 <- read.csv("C:/Downloads/quarters.csv", header=TRUE)

	##
	StudytypeExpandedAccesslin <- lm(myData2$Expanded.Access  ~ c(1:length(myData2$X)) )
	write.csv(predict(StudytypeExpandedAccesslin), "C:/Downloads/regresijaExpandedAccessQ.csv")
	plot(x=c(1:length(myData2$X)), y=myData2$Expanded.Access  ,main = "Number of clinical trials",xlab = "q-year", ylab = "number of clinical trials")
	lines(c(1:length(myData2$X)), predict(StudytypeExpandedAccesslin), type="l", col="red1", lwd=2)

	##
	StudytypeInterventionallin <- lm(myData2$Interventional  ~ c(1:length(myData2$X)) )
	write.csv(predict(StudytypeInterventionallin), "C:/Downloads/regresijaInterventionalQ.csv")
	plot(x=c(1:length(myData2$X)), y=myData2$Interventional  ,main = "Number of clinical trials",xlab = "q-year", ylab = "number of clinical trials")
	lines(c(1:length(myData2$X)), predict(StudytypeInterventionallin), type="l", col="red1", lwd=2)

	##
	StudytypeObservationallin <- lm(myData2$Observational  ~ c(1:length(myData2$X)) )
	write.csv(predict(StudytypeObservationalpol), "C:/Downloads/regresijaObservationalQ.csv")
	#plot(x=c(1:length(myData2$X)), y=myData2$Observational  ,main = "Number of clinical trials",xlab = "q-year", ylab = "number of clinical trials")
	#lines(c(1:length(myData2$X)), predict(StudytypeObservationalpol), type="l", col="red1", lwd=2)


	#summary(StudytypeObservationalpol)

	return("Ok")
}

check()
  