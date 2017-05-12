CREATE TABLE `characters` (
	`id`	INTEGER PRIMARY KEY AUTOINCREMENT,
	`name`	TEXT NOT NULL,
	`description`	TEXT NOT NULL,
	`img_path`	TEXT NOT NULL
);

CREATE TABLE `questions` (
	`id`	INTEGER PRIMARY KEY AUTOINCREMENT,
	`value`	TEXT NOT NULL UNIQUE
);

CREATE TABLE `character_questions` (
	`character_id`	INTEGER NOT NULL,
	`question_id`	INTEGER NOT NULL,
	FOREIGN KEY(`character_id`) REFERENCES `characters`(`id`) on update cascade on delete cascade,
	FOREIGN KEY(`question_id`) REFERENCES `questions`(`id`) on update cascade on delete cascade,
	PRIMARY KEY(`character_id`, `question_id`)
);