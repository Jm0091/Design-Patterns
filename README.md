<h1>Design-Patterns</h1>

Objectives:
 - Understand various design patterns 
 - Undestand implementing and the role of design patterns


Description:

 Problem 1:
  - For provided use case, Factor pattern suited the best and I used - 'Factory pattern'. The base design pattern solves the problem of creating abstract class for similar interface, creating different implementation, and abstracting everything with using 'factory creater' concept. I created abstract class for IToy, Factory creater - ToyCreator and multiple subclasses using IToy's properties. At first, I was little confused in Factory pattern and Builder pattern for the use case. But content from myCanvashelped me to figure it out and understand it properly.
    
Problem 2:
- Confusion between Builder pattern and Decorator pattern took much time for solving the problem of creating classes of ra computer. But at the end, I found 'Decorator Design Pattern' as a best suitable design pattern for the problem. It always to add more functionality easily on top of the class's object and according to modern computer's there are lot of variety and updates available. So, from this problem, I leant how Decorator design pattern is very helpful in some scenario. I used class example of Pizza and myCanvas's notes as a resource to solve the problem.

Problem 3:
- This Problem is uses Reactor Pattern to solve the problem. Reactor pattern is used to create event loop and send the request to different handler based on the resources required without blocking the thread receiving the initial request. Problem 3 is like the Reactor pattern where mailbox is the class that handles the initial request and needs to send the mail to appropriate mailbox based on the mail. This design pattern was complicated to understand and required lot of reading from the internet, also no good document was found over internet showing examples with less complexity.

Problem 4:
- Observer pattern was used to solve this problem. This problem was event based where everyone participating in the auction needed to be notified of the highest bids, updates. They can even leave the auction willingly if the wanted to, the observer pattern best fits this use case and provides the feature/functionality to perform all necessary task. This pattern was relatively easy in understanding and implementing, so there were not many problems encountered. Also, lots of resources were available over internet that explain the concept this pattern very well.
