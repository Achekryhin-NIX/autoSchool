Feature: SpecFlowFeature1
	Simple calculator for adding two numbers

@mytag
Scenario: Verify, pop up window  with notice   "Your e-mail has been sent successfully" are display after click the button Send 
	Given Internet Store;
	When Enter "T Shirt"  in search field and click button Search ;
	And  Select blue color of the product, and click on the button Send to a friend
	And Input name "Ann", and email "qqq@gmail.com" on popup window, and click button send;
	Then Verify, pop up window  with notice    "Your e-mail has been sent successfully" are display