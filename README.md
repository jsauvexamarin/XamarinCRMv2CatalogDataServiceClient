# XamarinCRMv2CatalogDataServiceClient
This is a standalone PCL that can be used to access the XamarinCRM v2 Azure Mobile Service

##Notes
* Requires an IDE that supports C# 6.0 features, such as Visual Studio 2015 or Xamarin Studio.
* The base URL for the service is currently: `https://xamarincrmv2-catalogdataservice.azure-mobile.net/api/`. Use that exact string, including the trailing slash.
* API key for the service is currently `IibptMvpFmJRBisbVyiCheBukYjzsD75`
* You must pass the base service URL and the API key to the constructor of the `CatalogDataClient` class
* You can access the API documentation here: https://xamarincrmv2-catalogdataservice.azure-mobile.net/help, for which you'll need to provide the API key as the password when prompted in your browser. Username is blank.

##Getting Started
* The best way to get started with the API is to call the `GetCategoriesAsync(string parentCategoryId = null)` method on `ICatalogDataClient`. Using the parameterless version of the method will get you the top-level categories. Once you have those, call for subcategories by using the parameterized version and one of the top-level catagory ids.
* Each category has a parent category id except for the root parent node of the category hierarchy, which has a null parent category.
* Each category has a `HasSubCategories` property. At this time, products only exist on leaf-level categories, so if a category's `HasSubCategories` property is false, you know that you can then query for a list of products for that category.
* To query for a product list, call the `GetProductsAsync(string categoryId)` method on `ICatalogDataClient`.
