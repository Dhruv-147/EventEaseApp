# EventEaseApp
I was guided in building the EventEaseApp Blazor web application by setting up a complete frontend architecture with routing, validation, state management, and performance optimization.

First, I implemented the core structure of the application, including the Event List, Event Details, and Registration pages with proper routing and navigation. I created a reusable EventCard component and used mock data models to dynamically display event name, date, and location using data binding.

Next, I added form validation to the registration page using Blazor’s EditForm and data annotations to ensure only valid user input (name and email) was processed. Error handling was tested for empty and invalid fields to guarantee smooth user interaction.

Then, I introduced state management to track user session data such as registered users and attendance using a scoped session service. This allowed the application to maintain continuity when navigating between pages.

An Attendance Tracker feature was added to record participant presence and prevent duplicate entries. The routing system was enhanced to handle invalid URLs gracefully by redirecting to a custom Not Found page.

Finally, I optimized performance by rendering large event lists using Blazor’s <Virtualize> component and tested the application with large datasets to ensure responsiveness and reliability.

This resulted in a fully functional, robust, and optimized Blazor web application suitable for real-world event management scenarios.
