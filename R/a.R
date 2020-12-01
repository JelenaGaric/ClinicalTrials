check <- function() {
	myData <- read.csv("C:/Downloads/studydays.csv", header=TRUE)
	tblday <- table(myData)
	write.csv(tblday, "C:/Downloads/uspjelo.csv")

	return("Zero")
}

check()
  