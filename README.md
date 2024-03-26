<h1>Design-Patterns</h1>

Objectives:
 - Understand various design patterns 
 - Undestand implementing and the role of design patterns

Description:
- There are 4 different problems given. Have to select each best design pattern its to the problem.
- Expected outcomes from this acitivity are to research, understand, and learn how to implement design patterns using best practices.  


  
<h3>Problem 1:</h3>
- Scenario: 
    Implement a series of classes to represent and create children’s toys. There are many types of children’s toys, the most prominent toys are cars, dollhouses, stuffed animals, and rainbow stackers. All toys consist of the following:
  
     1. Cost
     2. Description
     3. Name
     4. Manufacturing Company
     5. Year of manufacture
     6. Minimum age limit
     7. Maximum age limit
     8. Whether they contain parts which could be considered a choking hazard
     9. Weight
         
    Each class implemented must describe the toy that it represents and is not meant to be an empty class. Each class implemented must have a minimum of 3 properties which describe the toy and 2 methods which are actions the toy can perform. These additional properties do not have to be overly in-depth, however they must not be overly generic, (i.e. a property called colour would be applied to all toys and must not be used as a specific property of a given toy, however properties such as ring count and number of rooms would apply to a rainbow stacker and a dollhouse respectively). The methods must also be specific to the toy and follow the same rules as the additional properties.
     
- Explaination for selected design pattern:
   For provided use case, Factor pattern suited the best and I used - 'Factory pattern'. The base design pattern solves the problem of creating abstract class for similar interface, creating different implementation, and abstracting everything with using 'factory creater' concept. I created abstract class for IToy, Factory creater - ToyCreator and multiple subclasses using IToy's properties. At first, I was little confused in Factory pattern and Builder pattern for the use case. But content from myCanvashelped me to figure it out and understand it properly.




    
<h3>Problem 2:</h3>

- Scenario:
    Implement a series of classes to build a computer. A computer is a complex entity and consists of the following:
      1. Hard Drive
      a. Capacity
      b. Type (SSD or HDD)
      c. Read speed
      d. Write speed
  
      2. Motherboard
      a. Number of memory slots
      b. Power consumption
      c. Number of PCI slots
      d. Form factor
      e. Hard drive limit
      f. CPU
      g. Memory
      h. Graphics card
  
      3. CPU
      a. Speed
      b. Manufacturer (Intel, AMD)
      c. Socket Type
      d. Cache size
      e. Number of cores
  
      4. Memory
      a. Read speed
      b. Write speed
      c. Type (DDR1, DDR2, DDR3, DDR4)
      d. Amount in GB
  
      5. Graphics card
      a. Fan count
      b. Speed
      c. Video memory
      d. Number of CUDA cores
  
      6. Case
      a. Length
      b. Width
      c. Height
      d. Number of fans
      e. Number of vents
  
    Each class implemented should have error handling built in and throw exceptions when invalid or nonsensical information is provided, (i.e. a CPU cannot have a speed less than 0). All properties within each class must use the best datatype to represent the value, (i.e. CPU speed should be a double not an integer).

- Explaination for selected design pattern:
   Confusion between Builder pattern and Decorator pattern took much time for solving the problem of creating classes of ra computer. But at the end, I found 'Decorator Design Pattern' as a best suitable design pattern for the problem. It always to add more functionality easily on top of the class's object and according to modern computer's there are lot of variety and updates available. So, from this problem, I leant how Decorator design pattern is very helpful in some scenario. I used class example of Pizza and myCanvas's notes as a resource to solve the problem.




<h3>Problem 3:</h3>

- Scenario:
    Implement a series of classes to represent mailroom organization. Mail in a mailroom is continuously received and does not stop, these can be considered requests. When mail arrives in the mailroom, the dispatcher dispatches the mail to the appropriate worker and the workers run independently of the dispatcher to perform the following actions:
     
     1. Determine which mailbox to place the mail
     2. If the mail is marked as flagged, place the mail into a review queue
     3. Return to the dispatcher to receive more mail
   
     A piece of mail consists of the following:
       1. Sender
         a. Name
         b. Address
       2. Receiver
         a. Name
         b. Address
       3. Postal cost
       4. Weight
  
  Mail can be letters or packages. If the volume of mail increases, more workers are called in to assist with the increased number of requests
  
- Explaination for selected design pattern:
    This Problem is uses Reactor Pattern to solve the problem. Reactor pattern is used to create event loop and send the request to different handler based on the resources required without blocking the thread receiving the initial request. Problem 3 is like the Reactor pattern where mailbox is the class that handles the initial request and needs to send the mail to appropriate mailbox based on the mail. This design pattern was complicated to understand and required lot of reading from the internet, also no good document was found over internet showing examples with less complexity.





<h3>Problem 4:</h3>

- Scenario:
     Implement a series of classes to represent an auction. At an auction, there is an auctioneer who announces items for auction, prices for items being sold, and when the bidding for a given item is closed
   the auctioneer announces the highest bidder.
  
   During the process of the auction bidders can declare their amount which they would like to bid for a given item to the auctioneer. If a bidder bids a price higher than another bidder (or higher than the
   initial price of the item if the bid is the first bid) for the given item, the auctioneer then announces the new current price as the current price to all the bidders.
  
   An item can be bid upon a maximum of 5 times before being sold. Once an item is bid on 5 times, the highest bidder receives the item and leaves the auction and no longer receives updates about the
   auction. Bidders can register and unregister at will.
  
   Bidders have a maximum limit that they can spend for any given item and cannot exceed this limit. An item for auction has a starting bid price and year of creation.
  
- Explaination for selected design pattern:
    Observer pattern was used to solve this problem. This problem was event based where everyone participating in the auction needed to be notified of the highest bids, updates. They can even leave the auction willingly if the wanted to, the observer pattern best fits this use case and provides the feature/functionality to perform all necessary task. This pattern was relatively easy in understanding and implementing, so there were not many problems encountered. Also, lots of resources were available over internet that explain the concept this pattern very well.
