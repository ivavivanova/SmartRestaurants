<h1 align="center"> Master Degree Thesis <br /> on topic <br /> The "Restaurants of the Future" system</h1>

<h4 align="right"><i>Iva Ivanova,<br />E-business and e-government,<br />“Computing Systems” Department,<br />Faculty of Mathematics and Informatics,<br />Sofia University „St. Kl. Ochridski”, BG</i></h4>

## Summary
<div><i>&nbsp;&nbsp;&nbsp;&nbsp;The restaurant business has been established and built over the years, along with clear concepts and work processes. The human factor, nonetheless, plays a huge factor in each aspect which could often to troubling consequences.</i></div>
<div><i>&nbsp;&nbsp;&nbsp;&nbsp;The purpose of the thesis is to develop an automated restaurant management system. By implementing such a system, the staff workload would be optimized and the possibilities for human error would be reduced to minimum.</i></div>
<br />
<i><b>Keywords:</b> Restaurant business, automated system, Optimization</i>

## 1. Introduction
<div>&nbsp;&nbsp;&nbsp;&nbsp;The thesis describes the implementation of an automated restaurant management system - the "Restaurants of the future" which helps the development of easier processes and optimizes all the problematic areas in the restaurant business, minimizing human error. The need for such a development is motivated by two key factors - the current complications in the business (described in 2. Problems) and the benefits that such a development would bring for the business, namely:</div>

-	staff and cost reduction
-	work optimization
-	increase in capacity
-	larger profits, etc.	

and customers:
-	faster ordering
-	quicker payment taking process
-	a fully interactive experience, etc.

## 2. Problems
<div>&nbsp;&nbsp;&nbsp;&nbsp;The need for the development of the system arises due to some pressing matters in the restaurant business that could be defined as follows:</div>

-	indefinite time for accommodation in a restaurant
-	waiting for the menu arrival
-	waiting until the order is taken by a waiter
-	waiting until the bill is settled

## 3. Solution
<div>&nbsp;&nbsp;&nbsp;&nbsp;A solution to all these problems would be to reduce the human factor to a minimum, which can be achieved through a variety of technologies. For some of the problems, there are already existing solutions such as:</div>

-	apps and sites for the restaurant table reservations – there are many restaurant reservation pages on the web
-	e-menus - there are currently many applications that are quite different rooms - a tablet, an interactive mass or a QR code that can be scanned with the phone (i.e. the mobile application)
-	robots in the restaurants – they are used in the restaurants as staff – preferably hosts and waiters

<div>&nbsp;&nbsp;&nbsp;&nbsp;The solution to all of the above described problems is a complete system which is the subject of the thesis.</div>
<br />
<div>&nbsp;&nbsp;&nbsp;&nbsp;Since the overall system includes a variety of complex and functional modules, shown in <b>Diagram 1.</b>, the technologies used to develop it are diverse. The ultimate goal is building a flexible, secure and easy-to-use system.</div>

<p align="center">
  <img width="560" height="360" src="https://user-images.githubusercontent.com/19905455/57569709-9ed41800-7401-11e9-8ccc-9256858842f2.png"/>
</p>
<p align="center">
<b>Diagram 1.</b> <i>System conceptual model</i>
</p>

## 4. Implementation
<div>&nbsp;&nbsp;&nbsp;&nbsp;The ultimate purpose is to develop a flexible, secure and easy-to-use system, which in turn generates certain requirements for technology selection and development, for example:</div>
  
-	ensuring secure communication between the different modules
-	trouble-free work, regardless of server load
-	providing flexibility and easy system adaptability
-	easily readable and easily modifiable code

<div>&nbsp;&nbsp;&nbsp;&nbsp;The technologies and tools that will be used to develop the entire system are MSSQL, ASP.NET MVC, C #, JavaScript, CSS, HTML, Entity Framework, Python, interactive masses, Azure technology, IoT sensors (RFID modems) and Pepper (humanoid robot) (shown on <b>Diagram 2.</b>). These technologies are chosen for development after exploring their advantages and disadvantages and comparing them with other technologies that are currently being used. I have some experience with some of them, which makes the choice easier.</div>

<p align="center">
  <img width="500" height="290" src="https://user-images.githubusercontent.com/19905455/57569696-751af100-7401-11e9-936e-28b8bb783f5f.png"/>
</p>
<p align="center">
<b>Diagram 2.</b> <i>Common architecture and technologies</i>
</p>
<div>&nbsp;&nbsp;&nbsp;&nbsp;For the purposes of the thesis, prototypes for some of the modules shown in <b>Diagram 1.</b> have been developed. The prototypes have been developed with ASP.NET MVC, C#, JavaScript, CSS, HTML, Entity Framework, Repository and UnitOfWork Patterns, Visual Studio, and MSSQL (for the database).</div>

The prototypes are mentioned below:
1.	<b>Prototype of the application for information on free tables at the establishment</b>, which contains:
-	information on available free tables at the time – visitors would be able to choose their table and be informed at any time how many free tables are available at the venue.
-	information about the reservations – once a reservation is made the table would be marked and would be occupied for up to 30 minutes. It would no longer be displayed as "free for use". Any visitor who has made a reservation would be able to open his/ her table after entering an email address 

2.	<b>An on-line reservation platform prototype</b> that includes: 
-	reservation section - customers must fill in number of seats, type of table (smokers / non-smokers) and date and time of booking 
-	section showing current available tables in real time

3.	<b>Administration module</b> to meet the needs of prototypes – contains the business logic of both prototypes and provides the opportunity for additional administration of functionalities in the mentioned above.


## 5. Conclusion
<div>&nbsp;&nbsp;&nbsp;&nbsp;A large part of the business problems are already solved via the implementation of a variety of technologies and applications which means that businesses are aware of their benefits. That raises the idea of implementing a comprehensive system that would be preferred as it would save a lot of unnecessary costs for a variety of technologies and whose maintenance would be guaranteed by only one vendor. Such a system would also facilitate communication regarding problems across the various modules in the system.</div>
<div>&nbsp;&nbsp;&nbsp;&nbsp;Apart from all that, the system would also guarantee a completely new and innovative customer experience that would make the restaurants that use it as an extremely interesting and desirable destination.</div>

<br/><br/><h2 align="center"> References</h2>

1.	“Supported languages - Pepper”, Softbank Robotics, 2017, http://doc.aldebaran.com/2-5/family/pepper_technical/languages_pep.html
2.	Python,  Python Software Foundation, 2001-2019,  www.python.org/
3.	JavaScript, Pluralsight, 2016-2019, www.javascript.com/
4.	“MVC Architecture”, Tutorials Teacher, 2019, www.tutorialsteacher.com/mvc/mvc-architecture
5.	“Hmtl5 and related technologies”, last visited 16.02.2019, https://upload.wikimedia.org/wikipedia/commons/7/7f/HTML5_APIs_and_related_technologies_taxonomy_and_status.svg
6.	“Introducing in programming”, Introprogramming, 2008-2019, www.introprogramming.info/intro-csharp-book/read-online/glava1-vavedenie-v-programiraneto/
7.	Microsoft, Microsoft, 2019, www.microsoft.com/bg-bg/ 




