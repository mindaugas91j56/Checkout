# Checkout
Checkout
Please find solution for Checkout.
Implementation included several development stages as requested per phone interview. 
First stage , commit to Git repository was made to present TDD - Test driven development mentality. 
Where xUnit test class where implemented with code containing simple tests.
Test methods containing single item price check. These methods implement Arrange - Act-  Assert approach. Arrange 
in these methods - accessing Supermarket (Solution class) to containing method GetPrice method.

Second Stage of development , third and fourth, commits ovolved logic required for checkout supermarket. 
This included property classes - Product and Deals containing properties of items available in supermarket checkout. 
Suppermarket stock class implemented methods to populate Products and Deals classes with data provided in this Kata. 
In addition Supermarket provides with functionality to retrieve specific item- product name , price, multibuy quantity 
required to qualify for discounted price.

Third stage of development included interface class linking with inheritance to supermarket stock class. Test classes where updated with new test methods to use Scan and Getprice methods to verify data correctness. This stage of development also included re-evaluating code and if necessary amend it for better programming practice. As a part of evaluation i do can identify areas that could benefit from improvement. During implementation of interface i have identified that test classes can be potentially modified to test interface scenario. Mocking interface code sample ( as per below ) which with more time i believe could be included inside this project. 

            var iCheckout = new Mock<ICheckout>();
            iCheckout.Object.Scan("A");
            Assert.Equal(50, iCheckout.Object.GetTotalPrice());


Please feel free to contact me if you have any questions.
Thank you,
Mindaugas 
