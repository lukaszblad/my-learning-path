# Service50
Service50 is a ticketing system, inspired on the renowned platform ServiceNow. It serves as a centralized hub for logging IT issues, enabling users to report problems with hardware and software to the appropriate support teams.

## Distinctiveness and Complexity
### Distinctiveness
- Structured Communication: Service50 offers a structured way to log IT problems. This ensures that all necessary information is captured upfront, reducing back-and-forth communication.
- Centralized Repository: Service50 acts as a centralized repository for all IT issues and resolutions. This makes it easier to search for past incidents and track their resolution history.
- Task Assignment and Tracking: Service50 allows for easy assignment of tasks to responsible teams or individuals. This ensures accountability and streamlines the resolution process.
### Complexity
- Service50 implements several Django models to capture various aspects of IT problems such as relationships between various entities, enabling detailed tracking and analysis of IT issues.
- Service50 features multiple dashboards tailored to different entities specific of IT problem resolution. These dashboards provide users with quick access to relevant information and tools to address issues efficiently.

## Entities
### Incidents
In Service50, incidents form the cornerstone of the platform's functionality, serving as vital tools for addressing IT issues swiftly and effectively. These incidents encompass the entire lifecycle of problem resolution, from initial error reporting to documenting the resolution process comprehensively. Users utilize incidents to report errors, ensuring they are documented with precision and promptly routed to the appropriate teams for resolution. Furthermore, incidents serve as repositories for tracking the entire resolution journey, documenting each step taken to mitigate the issue until its successful resolution. Through this systematic approach, Service50 empowers organizations to streamline their IT support processes, fostering efficiency and accountability across the board.

Upon creation, each incident in Service50 is endowed with a unique identification code, generated through an API interface, and stamped with an opening datetime. These incidents undergo a structured journey, evolving through three distinct states. Initially classified as "New" upon inception, they represent freshly reported issues awaiting attention. As teams engage with the problem, incidents transition into the "In Progress" state, signifying active resolution efforts. Finally, upon successful mitigation, incidents ascend to the "Resolved" status, symbolizing the culmination of efforts and the restoration of operational integrity. This systematic approach ensures transparency and efficiency in incident management, providing clear delineation of each stage in the resolution process.
### Users
In Service50, users are organized into three distinct roles, each serving a crucial function within the support ecosystem. The role of "User" is designated for individuals seeking assistance with IT issues. These users rely on support provided by "Agents", who are organized into teams under the guidance of a designated "Manager". This hierarchical structure emulates that of a corporate environment.
### Services
Services serve as categorization codes for defining the nature of IT issues. Each service is associated with a dedicated support group, ensuring that problems are efficiently directed to the appropriate team for resolution.
### Configuration Items
Configuration items in Service5 represent individual hardware components susceptible to potential issues. These items are linked to users, reflecting the equipment assigned to them.
## Development
The website is built on a server crafted using Python's Django framework. Each page is constructed with HTML structure, predominantly stylized using row CSS, with additional enhancements using JavaScript. Data retrieval from the server occurs both during the compilation of HTTP responses and through JavaScript fetch requests, ensuring dynamic and responsive content delivery to users.

## Features to implement
### Requests
One feature slated for implementation in Service50 is the capability to handle specific requests along with their corresponding workflows.
### Knowledgebase 
A structured knowledgebase to ease the solution of common problems.
### Improve hierarchical structure
A well-defined organizational framework that reflects real-world operational dynamics.
<br/>
<br/>
<br/>
<br/>
_Created entirely by @lukaszblad as final project for CS50 Web_