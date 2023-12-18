CREATE TABLE
  `Client` (
    `id` integer not null primary key autoincrement,
    `created_at` datetime not null default CURRENT_TIMESTAMP,
    `name` varchar(50) null,
    `email` varchar(100) null,
    `isActived` BOOLEAN null default false
  )

