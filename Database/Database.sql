-- MySQL dump 10.13  Distrib 8.0.31, for Win64 (x86_64)
--
-- Host: localhost    Database: hoteldb
-- ------------------------------------------------------
-- Server version	8.0.31

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `booking`
--

DROP TABLE IF EXISTS `booking`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `booking` (
  `booking_id` varchar(5) NOT NULL,
  `booking_check_in` varchar(45) DEFAULT NULL,
  `booking_check_out` varchar(45) DEFAULT NULL,
  `booking_days` varchar(45) DEFAULT NULL,
  `booking_price` varchar(45) DEFAULT NULL,
  `customers_id` int DEFAULT NULL,
  `rooms_nr` int DEFAULT NULL,
  PRIMARY KEY (`booking_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `booking`
--

LOCK TABLES `booking` WRITE;
/*!40000 ALTER TABLE `booking` DISABLE KEYS */;
INSERT INTO `booking` VALUES ('10c74','0',NULL,NULL,NULL,NULL,NULL),('d3e43','2023-01-01','2023-01-07','6','720',10000,102);
/*!40000 ALTER TABLE `booking` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `customers`
--

DROP TABLE IF EXISTS `customers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `customers` (
  `customers_id` int NOT NULL AUTO_INCREMENT,
  `customers_first_name` varchar(45) DEFAULT NULL,
  `customers_last_name` varchar(45) DEFAULT NULL,
  `customers_phone` varchar(45) DEFAULT NULL,
  `customers_address` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`customers_id`)
) ENGINE=InnoDB AUTO_INCREMENT=10002 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customers`
--

LOCK TABLES `customers` WRITE;
/*!40000 ALTER TABLE `customers` DISABLE KEYS */;
INSERT INTO `customers` VALUES (10000,'Mustafa','Abdulle','123654789','Storgatan 1'),(10001,'0',NULL,NULL,NULL);
/*!40000 ALTER TABLE `customers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `rooms`
--

DROP TABLE IF EXISTS `rooms`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `rooms` (
  `rooms_nr` int NOT NULL AUTO_INCREMENT,
  `rooms_type` varchar(45) DEFAULT NULL,
  `rooms_price` varchar(45) DEFAULT NULL,
  `rooms_status` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`rooms_nr`)
) ENGINE=InnoDB AUTO_INCREMENT=710 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rooms`
--

LOCK TABLES `rooms` WRITE;
/*!40000 ALTER TABLE `rooms` DISABLE KEYS */;
INSERT INTO `rooms` VALUES (101,'Garden View','125','Available'),(102,'Double','120','BUSY'),(103,'Double','120','Available'),(104,'Double','120','Available'),(105,'Double','120','Available'),(106,'Double','120','Available'),(107,'Garden View','125','Available'),(108,'Garden View','125','Available'),(109,'Garden View','125','Available'),(201,'Double','120','Available'),(202,'Balcony','135','Available'),(203,'Balcony','135','Available'),(204,'Balcony','135','Available'),(205,'Single','100','Available'),(206,'Single','100','Available'),(207,'Single','100','Available'),(208,'Single','100','Available'),(209,'Single','100','Available'),(301,'Single','100','Available'),(302,'Single','100','Available'),(303,'Single','100','Available'),(304,'Single','100','Available'),(305,'Family','130','Available'),(306,'Family','130','Available'),(307,'Family','130','Available'),(308,'Family','130','Available'),(309,'Family','130','Available'),(401,'Family','130','Available'),(402,'Family','130','Available'),(403,'Family','130','Available'),(404,'Double','120','Available'),(405,'Double','120','Available'),(406,'Double','120','Available'),(407,'Double','120','Available'),(408,'Double','120','Available'),(409,'Double','120','Available'),(501,'Double','120','Available'),(502,'Double','120','Available'),(503,'King','170','Available'),(504,'King','170','Available'),(505,'Ocean View','150','Available'),(506,'Ocean View','150','Available'),(507,'Ocean View','150','Available'),(508,'Ocean View','150','Available'),(509,'King','170','Available'),(601,'King','170','Available'),(602,'Balcony','135','Available'),(603,'Ocean View','150','Available'),(604,'Balcony','135','Available'),(605,'Ocean View','150','Available'),(606,'Ocean View','150','Available'),(607,'Ocean View','150','Available'),(608,'Balcony','135','Available'),(609,'Balcony','135','Available'),(701,'King','170','Available'),(702,'King','170','Available'),(703,'Ocean View','150','Available'),(704,'Ocean View','150','Available'),(705,'Ocean View','150','Available'),(706,'King','170','Available'),(707,'King','170','Available'),(708,'Ocean View','150','Available'),(709,'Ocean View','150','Available');
/*!40000 ALTER TABLE `rooms` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-01-01 18:14:30
