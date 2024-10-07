# Point of sale system
A Point of Sale (POS) system in MAUI Blazor Hybrid is a desktop application designed to manage and facilitate the sale of products in retail environments. Using MAUI (Multi-platform App UI) and Blazor Hybrid, this system allows for a responsive, cross-platform user interface. Key features of this POS system include:

1. **Login Screen:** Users (like cashiers or admins) will input their username and password, which will be validated against credentials stored in a local SQLite database using Entity Framework as the ORM.

2. **Product Management (CRUD):** Users can create, read, update, and delete product entries. The system handles product details such as pricing, categories, and inventory levels.

3. **Sales Transactions:** The POS enables users to process sales by adding products to a transaction, calculating totals, applying discounts, and processing payments.

4. **Business Logic:** Includes functionalities such as inventory tracking, sales reporting, and alerting when stock is low.

5. **Entities:** At least two main entities will be implemented, such as "User" (for login and role-based access) and "Product" (to manage items in the store).

MAUI Blazor Hybrid allows for building a POS system with a web-based user experience, leveraging Blazor’s component-based framework while providing native desktop functionalities through MAUI.
