myData <- read.csv("E:/Szandi/Documents/_Munka/NCT0000xxxx-NCT0453xxxx-002.csv", header=TRUE)

library(date)
require(data.table)
library(lubridate)
library(xts)


study_first_submitted <- as.Date(myData$StudyFirstSubmitDate,format = "%m/%d/%Y")
study_type <- factor(myData$StudyType, order = TRUE, levels =c('Expanded Access','Interventional','Observational'))


############ study type by days
tblday <- table(study_first_submitted,study_type)
write.csv(tblday, "E:/Szandi/Documents/_Munka/linechart/studydays.csv")


########### study type by months
study_first_submitted_month   <- as.yearmon(study_first_submitted)
tblmonth <- table(study_first_submitted_month,study_type)
write.csv(tblmonth, "E:/Szandi/Documents/_Munka/linechart/studymonths.csv")


########### study type by quarter-year
study_first_submitted_Q   <- as.yearqtr(study_first_submitted)
tblQ <- table(study_first_submitted_Q,study_type)
write.csv(tblQ, "E:/Szandi/Documents/_Munka/linechart/studytypeQ.csv")


########### study type by years
study_first_submitted_year   <- year(as.IDate(study_first_submitted, "%m/%d/%Y"))
tblyear <- table(study_first_submitted_year,study_type)
write.csv(tblyear, "E:/Szandi/Documents/_Munka/linechart/studytypey.csv")





############# study type by days
myData2 <- read.csv("E:/Szandi/Documents/_Munka/linechart/studydays.csv", header=TRUE)

##
StudytypeExpandedAccesspol <- lm(myData2$Expanded.Access  ~ poly(c(1:length(myData2$X)),2 ))
plot(x=c(1:length(myData2$X)), y=myData2$Expanded.Access  ,main = "Number of clinical trials",xlab = "days", ylab = "number of clinical trials")
lines(c(1:length(myData2$X)), predict(StudytypeExpandedAccesspol), type="l", col="red1", lwd=2)

##
StudytypeInterventionallin <- lm(myData2$Interventional  ~ c(1:length(myData2$X)) )
plot(x=c(1:length(myData2$X)), y=myData2$Interventional  ,main = "Number of clinical trials",xlab = "days", ylab = "number of clinical trials")
lines(c(1:length(myData2$X)), predict(StudytypeInterventionallin), type="l", col="red1", lwd=2)

##
StudytypeObservationalpol <- lm(myData2$Observational  ~ poly(c(1:length(myData2$X)),2 ))
plot(x=c(1:length(myData2$X)), y=myData2$Observational  ,main = "Number of clinical trials",xlab = "days", ylab = "number of clinical trials")
lines(c(1:length(myData2$X)), predict(StudytypeObservationalpol), type="l", col="red1", lwd=2)




################### study type by months
myData2 <- read.csv("E:/Szandi/Documents/_Munka/linechart/studymonths.csv", header=TRUE)


##
StudytypeExpandedAccesspol <- lm(myData2$Expanded.Access  ~ poly(c(1:length(myData2$X)),2 ))
plot(x=c(1:length(myData2$X)), y=myData2$Expanded.Access  ,main = "Number of clinical trials",xlab = "months", ylab = "number of clinical trials")
lines(c(1:length(myData2$X)), predict(StudytypeExpandedAccesspol), type="l", col="red1", lwd=2)

##
StudytypeInterventionallin <- lm(myData2$Interventional  ~ c(1:length(myData2$X)) )
plot(x=c(1:length(myData2$X)), y=myData2$Interventional  ,main = "Number of clinical trials",xlab = "months", ylab = "number of clinical trials")
lines(c(1:length(myData2$X)), predict(StudytypeInterventionallin), type="l", col="red1", lwd=2)

##
StudytypeObservationalpol <- lm(myData2$Observational  ~ poly(c(1:length(myData2$X)),2 ))
plot(x=c(1:length(myData2$X)), y=myData2$Observational  ,main = "Number of clinical trials",xlab = "months", ylab = "number of clinical trials")
lines(c(1:length(myData2$X)), predict(StudytypeObservationalpol), type="l", col="red1", lwd=2)




################### study type by quarter-year
myData2 <- read.csv("E:/Szandi/Documents/_Munka/linechart/studytypeQ.csv", header=TRUE)

##
StudytypeExpandedAccesslin <- lm(myData2$Expanded.Access  ~ c(1:length(myData2$X)) )
plot(x=c(1:length(myData2$X)), y=myData2$Expanded.Access  ,main = "Number of clinical trials",xlab = "q-year", ylab = "number of clinical trials")
lines(c(1:length(myData2$X)), predict(StudytypeExpandedAccesslin), type="l", col="red1", lwd=2)

##
StudytypeInterventionallin <- lm(myData2$Interventional  ~ c(1:length(myData2$X)) )
plot(x=c(1:length(myData2$X)), y=myData2$Interventional  ,main = "Number of clinical trials",xlab = "q-year", ylab = "number of clinical trials")
lines(c(1:length(myData2$X)), predict(StudytypeInterventionallin), type="l", col="red1", lwd=2)

##
StudytypeObservationallin <- lm(myData2$Observational  ~ c(1:length(myData2$X)) )
plot(x=c(1:length(myData2$X)), y=myData2$Observational  ,main = "Number of clinical trials",xlab = "q-year", ylab = "number of clinical trials")
lines(c(1:length(myData2$X)), predict(StudytypeObservationalpol), type="l", col="red1", lwd=2)




############### study type by year
myData2 <- read.csv("E:/Szandi/Documents/_Munka/linechart/studytypey.csv", header=TRUE)

head(myData2)
##
StudytypeExpandedAccesspol <- lm(myData2$Expanded.Access  ~ poly(c(1:length(myData2$X)),2 ))
plot(x=c(1:length(myData2$X)), y=myData2$Expanded.Access  ,main = "Number of clinical trials",xlab = "year", ylab = "number of clinical trials")
lines(c(1:length(myData2$X)), predict(StudytypeExpandedAccesspol), type="l", col="red1", lwd=2)

##
StudytypeInterventionallin <- lm(myData2$Interventional  ~ c(1:length(myData2$X)) )
plot(x=c(1:length(myData2$X)), y=myData2$Interventional  ,main = "Number of clinical trials",xlab = "year", ylab = "number of clinical trials")
lines(c(1:length(myData2$X)), predict(StudytypeInterventionallin), type="l", col="red1", lwd=2)

##
StudytypeObservationalpol <- lm(myData2$Observational  ~ poly(c(1:length(myData2$X)),2 ))
plot(x=c(1:length(myData2$X)), y=myData2$Observational  ,main = "Number of clinical trials",xlab = "year", ylab = "number of clinical trials")
lines(c(1:length(myData2$X)), predict(StudytypeObservationalpol), type="l", col="red1", lwd=2)














