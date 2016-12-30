-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: 30 Des 2016 pada 06.37
-- Versi Server: 10.1.19-MariaDB
-- PHP Version: 5.6.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `latihan_pos`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `barang`
--

CREATE TABLE `barang` (
  `ID` int(10) NOT NULL,
  `Kode` varchar(20) NOT NULL,
  `Nama` varchar(100) NOT NULL,
  `JumlahAwal` int(10) NOT NULL,
  `HargaHPP` decimal(16,2) NOT NULL,
  `HargaJual` decimal(16,2) NOT NULL,
  `created_At` datetime NOT NULL,
  `updated_At` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `barang`
--

INSERT INTO `barang` (`ID`, `Kode`, `Nama`, `JumlahAwal`, `HargaHPP`, `HargaJual`, `created_At`, `updated_At`) VALUES
(1, '00001', 'Pulpen', 20, '2000.00', '3000.00', '2016-12-29 23:47:14', '2016-12-30 00:17:39'),
(2, '00002', 'Pensil', 11, '1200.00', '1800.00', '2016-12-29 23:47:36', '2016-12-30 12:35:35'),
(3, '00003', 'Penghapus', 37, '2000.00', '2500.00', '2016-12-29 23:48:08', '2016-12-30 12:35:12'),
(4, '00004', 'Blender', 100, '25000.00', '35000.00', '2016-12-29 23:48:31', '2016-12-30 12:36:23');

-- --------------------------------------------------------

--
-- Struktur dari tabel `customer`
--

CREATE TABLE `customer` (
  `ID` int(11) NOT NULL,
  `Nama` varchar(100) NOT NULL,
  `Alamat` varchar(200) NOT NULL,
  `Zip_code` varchar(20) NOT NULL,
  `Phone_number` varchar(20) NOT NULL,
  `Email` varchar(50) NOT NULL,
  `created_at` datetime NOT NULL,
  `updated_at` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `customer`
--

INSERT INTO `customer` (`ID`, `Nama`, `Alamat`, `Zip_code`, `Phone_number`, `Email`, `created_at`, `updated_at`) VALUES
(1, 'Ani', 'Jl angan 5', '20214', '0812654546', 'ani@gmail.com', '2016-12-24 08:19:23', '2016-12-30 12:36:34'),
(2, 'Anto', 'Jalan abcd', '20213', '082828282828', 'anto@yamil.com', '2016-12-27 04:29:23', '2016-12-29 16:10:45'),
(3, 'Budi', 'Jalan Budi...', '20214', '0878787878', 'Budi@ggmail.com', '2016-12-27 16:58:47', '2016-12-29 21:41:28'),
(4, 'Ali', 'Jalan Ali', '20222', '0857845481', 'Ali@gmail.com', '2016-12-29 16:59:21', '2016-12-29 16:59:21'),
(5, 'A', 'Jalan A', '12345', '02582', 'A@gmail.com', '2016-12-29 23:49:05', '2016-12-29 23:49:05'),
(6, 'B', 'B', '12345', '087878787', 'B@gmail.com', '2016-12-29 23:49:27', '2016-12-29 23:49:27');

-- --------------------------------------------------------

--
-- Struktur dari tabel `pembelian`
--

CREATE TABLE `pembelian` (
  `id` int(11) NOT NULL,
  `kode` varchar(10) NOT NULL,
  `id_supplier` int(11) NOT NULL,
  `created_at` datetime NOT NULL,
  `updated_at` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `pembelian`
--

INSERT INTO `pembelian` (`id`, `kode`, `id_supplier`, `created_at`, `updated_at`) VALUES
(1, '00001', 1, '2016-12-27 12:00:00', '2016-12-30 12:34:35'),
(2, '00002', 1, '2016-12-27 14:40:37', '2016-12-30 12:35:10'),
(3, '00003', 1, '2016-12-28 12:45:34', '2016-12-28 12:49:11'),
(4, '00004', 2, '2016-12-27 21:35:42', '2016-12-29 21:57:28'),
(5, '00005', 2, '2016-12-29 16:08:16', '2016-12-29 16:08:16'),
(6, '1', 1, '2016-12-30 12:07:24', '2016-12-30 12:33:25');

-- --------------------------------------------------------

--
-- Struktur dari tabel `pembelian_detail`
--

CREATE TABLE `pembelian_detail` (
  `id` int(11) NOT NULL,
  `Id_pembelian` int(11) NOT NULL,
  `id_barang` int(11) NOT NULL,
  `harga_barang` decimal(11,0) NOT NULL,
  `kuantitas` int(11) NOT NULL,
  `created_at` datetime NOT NULL,
  `updated_at` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `pembelian_detail`
--

INSERT INTO `pembelian_detail` (`id`, `Id_pembelian`, `id_barang`, `harga_barang`, `kuantitas`, `created_at`, `updated_at`) VALUES
(3, 1, 1, '2000', 11, '2016-12-27 13:35:46', '2016-12-30 00:17:39'),
(4, 1, 2, '1200', 3, '2016-12-27 13:53:44', '2016-12-30 12:34:37'),
(5, 2, 1, '10000', 9, '2016-12-27 13:55:29', '2016-12-27 13:55:29'),
(6, 1, 3, '50000', 3, '2016-12-27 14:04:31', '2016-12-27 14:04:31'),
(7, 4, 2, '100000', 12, '2016-12-27 22:04:40', '2016-12-29 14:52:54'),
(8, 4, 1, '10000', 12, '2016-12-28 13:44:47', '2016-12-28 13:44:47'),
(9, 4, 3, '50000', 2, '2016-12-29 16:07:37', '2016-12-29 16:07:37'),
(10, 4, 8, '4000', 6, '2016-12-29 21:49:57', '2016-12-29 21:57:32'),
(11, 6, 2, '1200', 2, '2016-12-30 00:00:45', '2016-12-30 12:33:27'),
(12, 2, 3, '2000', 10, '2016-12-30 12:35:12', '2016-12-30 12:35:12');

-- --------------------------------------------------------

--
-- Struktur dari tabel `penjualan`
--

CREATE TABLE `penjualan` (
  `id` int(11) NOT NULL,
  `kode` varchar(10) NOT NULL,
  `id_customer` int(11) NOT NULL,
  `created_at` datetime NOT NULL,
  `updated_at` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `penjualan`
--

INSERT INTO `penjualan` (`id`, `kode`, `id_customer`, `created_at`, `updated_at`) VALUES
(1, '00001', 1, '2016-12-29 20:21:42', '2016-12-30 12:35:34'),
(2, '00002', 1, '2016-12-29 21:55:42', '2016-12-29 21:56:25');

-- --------------------------------------------------------

--
-- Struktur dari tabel `penjualan_detail`
--

CREATE TABLE `penjualan_detail` (
  `id` int(11) NOT NULL,
  `id_penjualan` int(11) NOT NULL,
  `id_barang` int(11) NOT NULL,
  `harga_barang` decimal(10,2) NOT NULL,
  `kuantitas` int(11) NOT NULL,
  `created_at` datetime NOT NULL,
  `updated_at` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `penjualan_detail`
--

INSERT INTO `penjualan_detail` (`id`, `id_penjualan`, `id_barang`, `harga_barang`, `kuantitas`, `created_at`, `updated_at`) VALUES
(1, 1, 1, '12000.00', 20, '2016-12-27 18:23:39', '2016-12-27 19:25:05'),
(2, 1, 2, '1800.00', 5, '2016-12-27 18:25:34', '2016-12-30 12:35:35'),
(3, 2, 8, '5500.00', 8, '2016-12-29 21:56:27', '2016-12-29 21:56:27');

-- --------------------------------------------------------

--
-- Struktur dari tabel `supplier`
--

CREATE TABLE `supplier` (
  `ID` int(11) NOT NULL,
  `Nama` varchar(100) NOT NULL,
  `Alamat` varchar(200) NOT NULL,
  `Zip_code` varchar(20) NOT NULL,
  `Phone_Number` varchar(20) NOT NULL,
  `Email` varchar(50) NOT NULL,
  `created_at` datetime NOT NULL,
  `updated_at` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `supplier`
--

INSERT INTO `supplier` (`ID`, `Nama`, `Alamat`, `Zip_code`, `Phone_Number`, `Email`, `created_at`, `updated_at`) VALUES
(1, 'Supplier 1', 'Jalan Super 1', '11111', '021545', 'Sup@ymil.com', '2016-12-29 17:01:13', '2016-12-29 17:01:13'),
(2, 'Supplier 2', 'Jalan Sup No 2', '14785', '0825252525', 'Sup@gmail.com', '2016-12-29 23:50:00', '2016-12-29 23:50:00'),
(3, 'Supplier 3', 'Jalan sup 3', '14785', '08478786', 'sup3@gmail.com', '2016-12-29 23:54:06', '2016-12-29 23:54:06');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `barang`
--
ALTER TABLE `barang`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `pembelian`
--
ALTER TABLE `pembelian`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `pembelian_detail`
--
ALTER TABLE `pembelian_detail`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `penjualan`
--
ALTER TABLE `penjualan`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `penjualan_detail`
--
ALTER TABLE `penjualan_detail`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `supplier`
--
ALTER TABLE `supplier`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `barang`
--
ALTER TABLE `barang`
  MODIFY `ID` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT for table `customer`
--
ALTER TABLE `customer`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
--
-- AUTO_INCREMENT for table `pembelian`
--
ALTER TABLE `pembelian`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
--
-- AUTO_INCREMENT for table `pembelian_detail`
--
ALTER TABLE `pembelian_detail`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;
--
-- AUTO_INCREMENT for table `penjualan`
--
ALTER TABLE `penjualan`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `penjualan_detail`
--
ALTER TABLE `penjualan_detail`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `supplier`
--
ALTER TABLE `supplier`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
