The project is designed by using different data structures for different social media features. The main SocialMedia class connects all the structures and manages the complete system.

User Profiles: A Dictionary stores users using UserID as the key and UserProfile as the value. This makes user lookup fast.
Stories: Stories are stored in a Circular Doubly Linked List. Each story has a previous and next link, so users can move left or right. Since the list is circular, the last story connects back to the first.
Main Feed: Feed posts are stored in a Singly Linked List. New posts are added at the end, and the list can be traversed from the first post to the last.
Story Back Navigation: A Stack stores the stories opened by the user. Since a stack follows LIFO, the most recently opened story can be accessed first when going back.
Notifications: A Queue is used for notifications. It follows FIFO, so notifications are delivered in the same order in which they were received.
Sorting: Feed posts can be sorted based on engagement (likes + comments) or recency (newest posts first).
Searching: Followers are sorted alphabetically, and Binary Search is used to search for a username.
Testing: NUnit tests are used to check normal operations, empty cases, invalid users, story wrap-around, and integrated workflows.