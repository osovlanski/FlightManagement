# Flight Management System - Alert Management CRUD

This repository contains the implementation of a flight management system focusing on the **Alert Management** (CRUD) functionality as part of a multi-component design. The system is built using .NET 8 Minimal APIs and features a layered architecture separating the API, services, data access, and models.

## Overview

The system is designed to:
- **Receive Price Alerts:** Ingest flight price data from external airline APIs and price comparison services.
- **Send Push Notifications:** Dispatch notifications to users’ mobile devices when flight prices meet their alert criteria.
- **Manage Alerts and Users:** Provide CRUD operations for managing users’ alerts and related preferences.
- **Support High Loads:** Ensure scalability and high performance through a modular and layered design.

## Architecture Highlights

- **External Sources:** Data is collected from airline APIs and price comparison services.
- **Data Ingestion:** Price data is collected and normalized.
- **Core Processing:** Includes the Alert Matching Engine, which compares flight prices with stored alerts.
- **Alert Management API:** A unified API responsible for managing alerts and user data.
- **Notification System:** Queues and sends notifications to mobile clients.
- **Monitoring & Analytics:** Provides insights into system performance.

For a detailed diagram, refer to the `/Resources/Architecture/diagram.mmd` file.

## Data Structures

- **Alert:** Contains information about flight alerts including route, departure/return dates, price threshold, and other conditions.
- **Notification:** Contains details about notifications triggered when alerts match the criteria.
- **Price:** Holds the flight price information including dates, airline, price, and other relevant data.
- **User:** Contains user data including email, name, device tokens, and preferences.

## Technologies

- **.NET 8**
- **C# Minimal APIs**
- **In-Memory Repository** (for demonstration; can be replaced with a persistent database)
- **Postman** for testing API endpoints

## Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- An IDE such as [Visual Studio](https://visualstudio.microsoft.com/) or [Rider](https://www.jetbrains.com/rider/)
- [Git](https://git-scm.com/)

### Building and Running the API

1. **Clone the Repository:**

   ```bash
   git clone https://github.com/yourusername/FlightManagement.git
   cd FlightManagement
