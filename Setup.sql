CREATE TABLE IF NOT EXISTS jobs(
  id int NOT NULL primary key AUTO_INCREMENT COMMENT 'primary key',
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
  updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
  name varchar(255) COMMENT 'Jobs Name',
  description varchar(255) COMMENT 'Jobs Description',
  location varchar(255) COMMENT 'Jobs Location',
  salary int COMMENT 'Jobs Pay'
);
/* Contractors */
CREATE TABLE IF NOT EXISTS contractors(
  id int NOT NULL primary key AUTO_INCREMENT COMMENT 'primary key',
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
  updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
  name varchar(255) COMMENT 'Contractors Name',
  skill varchar(255) COMMENT 'Contractors Skills'
);
/* Many2Many */
CREATE TABLE IF NOT EXISTS contractors_jobs(
  id int NOT NULL primary key AUTO_INCREMENT COMMENT 'primary key',
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
  updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
  contractorId int NOT NULL COMMENT 'FK: Contractors Relationship',
  jobId int NOT NULL COMMENT 'FK: Jobs Relationship',
  FOREIGN KEY (contractorId) REFERENCES contractors(id) ON DELETE CASCADE,
  FOREIGN KEY (jobId) REFERENCES jobs(id) ON DELETE CASCADE
);
/* Adding hardcode into jobs */
INSERT INTO
  contractors_jobs (contractorId, jobId)
VALUES
  (1, 1);
  /* Adding hardcode into contractors_jobs */
INSERT INTO
  jobs (name, description, location, salary)
VALUES
  (
    "Coding Music",
    "Write some code that makes beautiful music",
    "Boise, ID",
    5000
  );
  /* Adding hardcode into contractors */
INSERT INTO
  jobs (name, description, location, salary)
VALUES
  (
    "Coding Music",
    "Write some code that makes beautiful music",
    "Boise, ID",
    5000
  );
SELECT
  j.*,
  c.name as contractorName,
  c.skill,
  cj.Id as contractorsJobsId,
  cj.jobId as jobId,
  cj.contractorId as contractorId
FROM
  contractors_jobs cj
  JOIN contractors c ON c.id = cj.contractorId
  JOIN jobs j ON j.id = cj.jobId
WHERE
  cj.contractorId = 1;
  /* SELECT * FROM jobs */
  /* SELECT * FROM contractors */
  /* SELECT
                  *
                FROM
                  contractors_jobs */
  -----------
  /* MySql Join Statement */