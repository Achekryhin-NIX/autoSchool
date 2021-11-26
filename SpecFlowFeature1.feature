Feature: SpecFlowFeature1
	

@mytag
Scenario: Verify the product successfully added to shopping cart;
	Given Internet Store
	When Enter "Blouse" in search field and click button search, and click button More
	When On details of the product Input : Quantity = "3" , Size = L, Color = white, and click button Add to cart
	Then text "Product successfully added to your shopping cart" are displayed in console

	@mytag
Scenario: Verify the notice "Summer" are visible
	Given Int Store
	When Enter "Summer" in search field and click button search
	Then text "Summer" are visible on top of the list of products;
	