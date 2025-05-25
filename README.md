# Inventory Management Desktop App

A desktop inventory management application built using Visual Basic (VB). This application allows users to track and manage inventory data, view reports, edit item entries, and perform a variety of inventory management tasks. 

Currently, the app is in an early stage, with a login screen as a placeholder, and no database or API connection yet. Data is handled through variables and basic UI elements.

## Features

- **Login Screen**: Placeholder login using hardcoded variables (no backend or API yet).
- **Home Screen**: Displays a DataGridView with the following columns:
  - Item Name
  - Purchase Date
  - Amount
  - Source
  - Destination
  - Action (Edit button for each row)
  
- **Edit Screen**: Allows modification of inventory items, including:
  - Suppliers (dropdown list initialized with current row’s supplier)
  - Destination Warehouse
  - Item list (add and remove items)
  - Numeric Up-Down Picker for adjusting item amounts
  
- **Sorting**: Click column headers in the DataGridView to sort by column.
- **Inventory Report**: View reports of current stock per branch, incoming stocks, and out-of-stock items.
- **Purchase Items**: A screen for adding purchase items, similar to the Edit screen, but without selecting an existing row.
- **Remove Items**: Delete items directly from the Home Screen DataGridView.
- **Logout**: Log out of the app using a simple button.

## Installation

1. Clone this repository to your local machine:
git clone https://github.com/codingSchedar/InventorySystem.git

markdown
Copy
Edit

2. Open the solution in **Visual Studio 2022** (or another IDE that supports VB.NET projects).

3. Build and run the application.

- **Note**: This app does not currently connect to a backend database or API. All data is handled locally.

## Usage

1. Open the app and log in using the placeholder credentials.
2. On the **Home Screen**, you can:
- View existing inventory entries.
- Edit entries by clicking the "Edit" button for any row.
- Remove inventory items by selecting a row and clicking "Remove."
- Sort the data by clicking on column headers.

3. Use the **Inventory Report** screen to check stock levels across branches.
4. The **Purchase Items** screen is used to add new purchase items to the inventory.
5. You can log out using the **Logout** button on the home screen.

## Screenshots
![Screenshot 2025-05-21 121236](https://github.com/user-attachments/assets/1eb470b1-0b33-499d-baca-f23e6a6928db)
![Screenshot 2025-05-21 121218](https://github.com/user-attachments/assets/3fd69957-7b9a-4db8-9dca-6c7732c284bf)
![Screenshot 2025-05-21 121206](https://github.com/user-attachments/assets/268bddeb-44e4-49fe-af82-845cbe121e70)
![Screenshot 2025-05-21 121156](https://github.com/user-attachments/assets/07b160ac-ac39-4395-962e-cc321c761cf1)
![Screenshot 2025-05-21 121132](https://github.com/user-attachments/assets/d0ceb3d1-4773-442c-acac-e5367a25294d)
