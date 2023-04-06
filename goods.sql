-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 05, 2023 at 09:11 AM
-- Server version: 10.4.27-MariaDB
-- PHP Version: 8.1.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `goods`
--

-- --------------------------------------------------------

--
-- Table structure for table `ginfo`
--

CREATE TABLE `ginfo` (
  `gid` int(20) NOT NULL,
  `gname` varchar(20) NOT NULL,
  `gcpny` varchar(40) NOT NULL,
  `gout` int(8) NOT NULL,
  `gexp` int(8) NOT NULL,
  `image` varchar(40) NOT NULL,
  `gtrack` varchar(20) NOT NULL,
  `gprize` int(10) NOT NULL,
  `gstock` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `ginfo`
--

INSERT INTO `ginfo` (`gid`, `gname`, `gcpny`, `gout`, `gexp`, `image`, `gtrack`, `gprize`, `gstock`) VALUES
(789, 'dasdfasdasd', 'dssadas', 5, 56, '56566', '1235896587', 109000, 20),
(21, 'kokokoko', 'kokokok', 89, 98, '55', '1259869583', 59, 59),
(20, 'kokokoko', 'kokokok', 89, 98, '55', '1569875689', 59, 59),
(19, 'fdskf;jsjfkld;sjf;l', 'jds;lafkjsdfkl;a', 58, 58, 'sdfdsfdsfa', '1596589658', 10240, 20),
(89, '5456dasd', 'asdasd4as56d4', 56, 68, '8559595', '1598698745', 5000, 59);

-- --------------------------------------------------------

--
-- Table structure for table `ginoder`
--

CREATE TABLE `ginoder` (
  `gname` varchar(20) NOT NULL,
  `gid` int(20) NOT NULL,
  `gtrack` varchar(20) NOT NULL,
  `gprize` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `s_taff`
--

CREATE TABLE `s_taff` (
  `Id` varchar(20) NOT NULL,
  `pass` varchar(20) NOT NULL,
  `uniqcod` varchar(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `s_taff`
--

INSERT INTO `s_taff` (`Id`, `pass`, `uniqcod`) VALUES
('joj595', '123456789', '666666'),
('n', 'n', 'n');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `ginfo`
--
ALTER TABLE `ginfo`
  ADD PRIMARY KEY (`gtrack`),
  ADD UNIQUE KEY `gid` (`gid`);

--
-- Indexes for table `s_taff`
--
ALTER TABLE `s_taff`
  ADD PRIMARY KEY (`Id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
