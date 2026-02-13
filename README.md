# Multithread Order and Stock Management System

A concurrent order processing and stock management desktop application developed using C#, Windows Forms and MSSQL.

This project was implemented as part of the Software Laboratory course and focuses on multithreading, synchronization mechanisms and dynamic priority scheduling.

## Project Overview

The system simulates a multi-customer environment where orders are processed concurrently while maintaining stock consistency and database integrity.

The main objective is to handle simultaneous access to shared resources using:

- Multithreading
- Mutex and synchronization primitives
- Dynamic priority scheduling
- Real-time stock updates

## Technologies Used

- C#
- Windows Forms
- MSSQL
- Multithreading (Thread class)
- Mutex / synchronization mechanisms

## Core Concepts Implemented

### Concurrent Order Processing

Each customer order is processed in a separate thread.  
Threads operate independently but share access to stock and database resources.

### Synchronization Mechanisms

To prevent race conditions and inconsistent stock updates:

- Mutex is used to control access to critical sections.
- Database operations are protected to avoid deadlocks and inconsistencies.

### Dynamic Priority System

Customers are categorized as:

- Premium
- Standard

Priority Score Formula:

PriorityScore = BasePriority + (WaitingTime × 0.5)

Base Priority:
- Premium: 15
- Standard: 10

Standard customers increase in priority as waiting time increases.

### Stock Management

- Real-time stock updates
- Order rejection if stock is insufficient
- Immediate stock deduction upon successful purchase

### Budget Control

- Each customer has a budget (randomly assigned between 500–3000 TL)
- Orders are rejected if budget is insufficient

### Logging System

Every transaction generates a log entry including:

- Customer ID
- Order ID
- Log type (Info / Warning / Error)
- Product and quantity
- Timestamp
- Result message

Examples of error types:
- Insufficient stock
- Timeout
- Insufficient balance
- Database error

## UI Features

- Customer panel with dynamic priority display
- Real-time log panel
- Stock visualization with charts
- Animated order processing indicators

## Database Schema

Main tables:

- Customers
- Products
- Orders
- Logs

Relational integrity is maintained using foreign keys.

## Performance and Testing

The system was tested for:

- Concurrent order accuracy
- Synchronization correctness
- Stock consistency
- Database integrity under high load

Results confirm that mutex-based synchronization prevents race conditions and maintains data consistency.

## Academic Context

This project demonstrates:

- Process and thread management
- Synchronization techniques
- Dynamic scheduling algorithms
- Real-time UI updates in multithreaded environments
- Database optimization


