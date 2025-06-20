# 📅 Events Planner Platform

A powerful full-stack web platform for planning, organizing, and managing events — built with usability and scalability in mind.  
This project supports **multiple user roles**, event scheduling, attendee registration, and real-time feedback collection.

---

## 🚀 Project Highlights

- 🎭 Multi-role System: Regular Users, Event Organizers, and Admins  
- 📆 Event creation and scheduling  
- 🧍 Attendee registration and check-in  
- 📍 Venue and capacity management  
- 🗣️ Feedback collection and analysis  
- 🔍 Smart event search and filtering

---

## 👥 User Roles

| Role             | Permissions                                                                 |
|------------------|-----------------------------------------------------------------------------|
| 🧑 Regular User   | Browse events, register as attendee, and submit feedback                   |
| 🧑‍💼 Organizer     | Create and manage events, view attendee list and feedback                 |
| 👮 Admin          | Full access: Manage users, events, venues, feedback                        |

---

## 🗃️ Key Entities

| Entity       | Description                                                                                     |
|--------------|-------------------------------------------------------------------------------------------------|
| 📅 **Event**         | Includes ID, name, date, time, description, location, and organizer                     |
| 👤 **Attendee**      | Includes ID, name, contact info, and registration status                                |
| 🧑‍💼 **Organizer**    | Host of the event, with contact details and management rights                           |
| 🏢 **Location**      | Event venue with name, address, capacity, and amenities                                |
| 📝 **Registration**  | Connects attendees to events (Event ID, Attendee ID, Status)                            |
| 🕒 **Schedule**      | Links events with venue, date, time, and organizer ID                                   |

---

## ⚙️ Core Features

### ➕ Event Creation
Organizers can create new events by submitting detailed forms for time, venue, description, and capacity.

### 📝 Registration Management
Attendees can register through a simple UI, and their data is recorded securely.

### ✅ Attendee Check-in
Verify attendees during the event with check-in and live attendance tracking.

### 💬 Feedback Collection
Post-event surveys let users share feedback for continuous improvement.

### 🔎 Event Search & Filter
Search for events by **keyword, date, location**, and more.

---

## 🧪 Tech Stack

| Area           | Tech Used                       |
|----------------|----------------------------------|
| 🌐 Frontend    | HTML, CSS, JavaScript (assumed)  |
| 🧠 Backend     | Node.js / Express.js             |
| 🗃️ Database     | SQL Server (or relational DB)     |
| 🗂️ ORM/Driver   | Sequelize / ODBC (optional)       |

---

## 🚦 Getting Started

### 🔃 1. Clone the Repository
```bash
git clone https://github.com/username/events-planner.git
cd events-planner
```

### 🛠️ 2. Environment Setup
- Make sure to configure your database credentials in a `.env` file or config object.

### 🧱 3. Database Initialization
Run the SQL script to create required tables:

```sql
-- From file:
SQL-Code-for-Tables.sql
```

### ▶️ 4. Start the Application
```bash
npm install
npm start
```
Then visit [http://localhost:3000](http://localhost:3000) 🌐

---

## 👨‍💼 How Users Interact

### 👤 Regular User
- Register / Login
- Browse upcoming events
- Register and attend
- Leave feedback

### 🧑‍💼 Event Organizer
- Log in and create events
- Manage schedules and view attendees
- Analyze feedback

### 👮 Admin
- Access full admin dashboard
- Manage all users, events, and submissions

---

## 📂 Folder Structure (Example)

```
events-planner/
│
├── routes/                  # API routes (auth, events, feedback)
├── views/                   # HTML templates or frontend files
├── models/                  # Data models
├── SQL-Code-for-Tables.sql  # DB schema setup
├── .env                     # Config (excluded from Git)
├── server.js                # Main app entry
└── README.md
```

---

## 📄 License

This project is licensed under the **MIT License**.  
See the [LICENSE.txt](LICENSE.txt) file for details.

---

## 🧑‍💻 Author

**Hossam Elsabbagh**  
🎓 Computer Science & AI Student at Zewail City  
🔧 Passionate about tech, teamwork, and innovation  

> “Planning events isn’t just about scheduling — it’s about connecting people.” 🤝

---


