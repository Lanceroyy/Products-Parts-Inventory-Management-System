# Products-Parts Inventory Management System

A Windows Forms C# .NET application for managing parts and products in a small manufacturing organization. This system enables users to add, modify, delete, and associate parts with products, replacing the outdated spreadsheet-based process.

---

## Features

### Main Form
- **Controls**:
  - Buttons: `Add`, `Modify`, `Delete`, `Search`, and `Exit`
  - Lists: Display all parts and products
  - Textboxes: Search for parts and products
  - Labels: Application title, `Parts`, and `Products`

- **Behaviors**:
  - Redirect to `Add` or `Modify` forms for parts and products
  - Delete selected parts or products (requires confirmation)
  - Search and display matching results
  - Exit the application

### Add Part Form
- **Controls**:
  - Radio Buttons: `In-House` and `Outsourced`
  - Buttons: `Save` and `Cancel`
  - Textboxes: `ID`, `Name`, `Inventory Level`, `Price`, `Max/Min Values`, and `Company Name` or `Machine ID`
  - Labels: Corresponding to the textboxes and form title

- **Behaviors**:
  - Select part type (`In-House` or `Outsourced`)
  - Enter part details and save
  - Cancel and return to the main form

### Modify Part Form
- **Controls**: Same as the `Add Part` form, with fields pre-populated with the selected part data.
- **Behaviors**:
  - Modify part details and save changes
  - Cancel and return to the main form

### Add Product Form
- **Controls**:
  - Buttons: `Save`, `Cancel`, `Add Part`, and `Delete Part`
  - Textboxes: `ID`, `Name`, `Inventory Level`, `Price`, `Max/Min Values`
  - Labels: Corresponding to the textboxes and form title
  - Grid Views: Display all parts and associated parts
  - Search: Search field, button, and results list

- **Behaviors**:
  - Enter product details and save
  - Associate or disassociate parts with the product
  - Cancel and return to the main form

### Modify Product Form
- **Controls**: Same as the `Add Product` form, with fields pre-populated with the selected product data.
- **Behaviors**:
  - Modify product details and save changes
  - Associate or disassociate parts with the product
  - Cancel and return to the main form

---

## Class Implementation
- **Classes**: Developed according to the provided UML Class Diagram.
- **Behaviors**:
  - Perform CRUD operations for parts and products
  - Associate parts with products

---

## Input Validation
The application prevents the following errors:
1. Non-numeric input in fields requiring numeric values.
2. Invalid bounds: `Min` greater than `Max` or `Inventory` outside `Min`/`Max`.
3. Deletion of parts associated with a product.
4. Accidental deletion without user confirmation.

---

## Technologies Used
- **Programming Language**: C#
- **Framework**: .NET Windows Forms

---

## Getting Started
1. Clone the repository:
   ```bash
   git clone https://github.com/YourUsername/Products-Parts-Inventory-System.git
2. Open the solution file in Visual Studio.
3. Build and run the application.
