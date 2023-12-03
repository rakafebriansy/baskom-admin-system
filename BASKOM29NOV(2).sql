CREATE TABLE "Data_BKP"(
	id_bkp serial primary key NOT NULL,
	bkp varchar(64) NOT NULL,
	deskripsi_bkp text NOT NULL
);

CREATE TABLE "Data_Mitra"(
	id_mitra serial primary key NOT NULL,
    nama_mitra varchar(255) UNIQUE NOT NULL,
    deskripsi_mitra text NOT NULL
);

CREATE TABLE "Data_Program"(
	id_program serial PRIMARY KEY NOT NULL,
	nama_program varchar(64) UNIQUE NOT NULL
);

CREATE TABLE "Data_Mata_Kuliah" (
	id_matkul serial PRIMARY KEY NOT NULL,
	kode_matkul varchar(7) UNIQUE NOT NULL,
	nama_matkul varchar(50) UNIQUE NOT NULL,
	sks int NOT NULL
);

CREATE TABLE "Data_Detail_Program" (
	id_matkul int NOT NULL REFERENCES "Data_Mata_Kuliah"(id_matkul) NOT NULL,
	id_program int REFERENCES "Data_Program"(id_program) NOT NULL
);

CREATE TABLE "Data_Detail_Mitra" (
	id_program int REFERENCES "Data_Program"(id_program) NOT NULL,
	id_mitra int REFERENCES "Data_Mitra"(id_mitra) NOT NULL
);


CREATE TABLE "Data_Prodi" (
	id_prodi serial PRIMARY KEY NOT NULL,
	nama_prodi varchar(24) UNIQUE NOT NULL
);

CREATE TABLE "Data_Akun_Dosen"(
	id_dosen serial primary key NOT NULL,
	nip varchar(18) UNIQUE NOT NULL,
	nidn varchar(10) UNIQUE NOT NULL,
	nama_dosen varchar(115) NOT NULL,
	no_wa varchar(13) UNIQUE NOT NULL,
	email varchar(64) UNIQUE NOT NULL,
	kata_sandi varchar(64) NOT NULL
);

CREATE TABLE "Data_Akun_Timmbkm"(
	id_timmbkm serial primary key NOT NULL,
	nidn varchar(10) UNIQUE NOT NULL,
	id_dosen int REFERENCES "Data_Akun_Dosen"(id_dosen) NOT NULL
);

CREATE TABLE "Data_Akun_Mahasiswa"(
	id_mahasiswa serial primary key NOT NULL,
    nim varchar(12) UNIQUE NOT NULL,
    nama_mahasiswa varchar(115) NOT NULL,
    tahun_masuk int NOT NULL,
    status_mahasiswa smallint NOT NULL,
    no_wa varchar(13) UNIQUE NOT NULL,
    batch_mbkm int NOT NULL,
    email varchar(64) UNIQUE NOT NULL,
    kata_sandi varchar(64) NOT NULL,
    id_prodi int REFERENCES "Data_Prodi"(id_prodi) NOT NULL
);

CREATE TABLE "Data_Mata_Kuliah_Tempuh"(
	id_matkul int REFERENCES "Data_Mata_Kuliah"(id_matkul) NOT NULL,
    id_mahasiswa int REFERENCES "Data_Akun_Mahasiswa"(id_mahasiswa) NOT NULL
);

CREATE TABLE "Data_Status_Validasi_Mitra"(
	id_status_validasi serial primary key NOT NULL,
	status_validasi varchar(24) NOT NULL
);

CREATE TABLE "Data_Pengajuan_Mitra"(
	id_pengajuan serial primary key NOT NULL,
	nama_mitra varchar(64) UNIQUE NOT NULL,
	deskripsi_mitra text NOT NULL,
	id_status_validasi int NOT NULL,
	id_mahasiswa int REFERENCES "Data_Akun_Mahasiswa"(id_mahasiswa) NOT NULL
);

CREATE TABLE "Data_Akun_Admin"(
	id_admin serial primary key NOT NULL,
	nama_admin varchar(64) NOT NULL,
	email varchar(18) UNIQUE NOT NULL,
	kata_sandi varchar(64) NOT NULL
);

CREATE TABLE "Data_Konversi_SKS"(
	id_konversi_sks serial primary key NOT NULL,
	kompetensi text NOT NULL,
    deskripsi_kompetensi text NOT NULL,
	status_validasi smallint NOT NULL,
    id_matkul int REFERENCES "Data_Mata_Kuliah"(id_matkul) NOT NULL,
	id_mahasiswa int REFERENCES "Data_Akun_Mahasiswa"(id_mahasiswa) NOT NULL
);


CREATE TABLE "Data_Konversi_Nilai" (
	id_konversi_nilai serial primary key NOT NULL,
	nilai int NOT NULL,
	file_laporan_akhir varchar(100) NOT NULL,
	status_validasi smallint NOT NULL,
	id_konversi_sks int REFERENCES "Data_Konversi_SKS"(id_konversi_sks) NOT NULL
);

CREATE TABLE "Data_Penerimaan_Mitra"(
	id_penerimaan serial primary key NOT NULL,
    status_pkl smallint NOT NULL,
    no_wa varchar(13) UNIQUE NOT NULL,
    jumlah_sks varchar(13) NOT NULL,
    bukti_penerimaan varchar(255) NOT NULL,
	id_bkp int REFERENCES "Data_BKP"(id_bkp) NOT NULL,
    id_mitra int REFERENCES "Data_Mitra"(id_mitra) NOT NULL,
    id_dosen int REFERENCES "Data_Akun_Dosen"(id_dosen) NOT NULL,
    id_mahasiswa int REFERENCES "Data_Akun_Mahasiswa"(id_mahasiswa) NOT NULL UNIQUE,
	id_program int REFERENCES "Data_Program"(id_program) NOT NULL
);

CREATE TABLE "Data_Pembagian_Tugas"(
	id_tugas serial primary key NOT NULL,
	id_mahasiswa int REFERENCES "Data_Akun_Mahasiswa"(id_mahasiswa) NOT NULL UNIQUE,
	id_timmbkm int REFERENCES "Data_Akun_Timmbkm"(id_timmbkm) NULL
);

INSERT INTO "Data_Status_Validasi_Mitra" (status_validasi) VALUES ('Belum Dibuat'),('Sudah Dibuat'),('Telah Diajukan'),('Telah Disetujui Mitra'),('Selesai');

INSERT INTO "Data_BKP" (bkp, deskripsi_bkp) 
VALUES ('Pertukaran Mahasiswa Merdeka', 'Program Pertukaran Mahasiswa Merdeka merupakan sebuah program mobilitas mahasiswa selama satu semester untuk mendapatkan pengalaman belajar di perguruan tinggi di Indonesia sekaligus memperkuat persatuan dalam keberagaman.'),
('Magang', 'Magang Bersertifikat adalah bagian dari program Kampus Merdeka yang bertujuan untuk memberikan kesempatan kepada mahasiswa belajar dan mengembangkan diri melalui aktivitas di luar kelas perkuliahan. Di program Magang Bersertifikat, mahasiswa akan mendapatkan pengalaman kerja di industri/dunia profesi nyata selama 1-2 semester. Dengan pembelajaran langsung di tempat kerja mitra magang, mahasiswa akan mendapatkan hard skills maupun soft skills yang akan menyiapkan mahasiswa agar lebih mantab untuk memasuki dunia kerja dan karirnya.'),
('Kampus Mengajar', 'Kampus Mengajar merupakan kanal pembelajaran yang memberikan kesempatan kepada mahasiswa untuk belajar di luar kampus selama satu semester guna melatih kemampuan menyelesaikan permasalahan yang kompleks dengan menjadi mitra guru untuk berinovasi dalam pembelajaran, pengembangan strategi, dan model pembelajaran yang kreatif, inovatif, dan menyenangkan.'),
('Studi Independen', 'Studi Independen Bersertifikat adalah bagian dari program Kampus Merdeka yang bertujuan untuk memberikan kesempatan kepada mahasiswa untuk belajar dan mengembangkan diri melalui aktivitas di luar kelas perkuliahan, namun tetap diakui sebagai bagian dari perkuliahan. Program ini diperuntukan bagi mahasiswa yang ingin memperlengkapi dirinya dengan menguasai kompetensi spesifik dan praktis yang juga dicari oleh dunia usaha dunia industri.'),
('Asistensi Mengajar', 'Program Asistensi Mengajar di satuan pendidikan adalah bentuk kegiatan pembelajaran yang dilakukan mahasiswa secara kolaboratif di bawah bimbingan guru dan dosen pembimbing di satuan pendidikan formal (Kampus Merdeka)'),
('Penelitian Mahasiswa', 'Penelitian atau riset merupakan bentuk kegiatan pembelajaran untuk membangun cara berpikir kritis mahasiswa yang memiliki passion menjadi peneliti untuk lebih mendalami, memahami, dan melakukan metode riset secara lebih baik yang sangat dibutuhkan untuk berbagai rumpun keilmuan pada jenjang pendidikan tinggi. Pelaksanaan bentuk kegiatan pembelajaran penelitian dapat dilaksanakan selama 1-2 semester dan memperoleh pengakuan yang setara dengan 20 sks pada setiap semesternya.'),
('Wirausaha Merdeka','Wirausaha Merdeka adalah bagian dari program Kampus Merdeka Kementerian Pendidikan, Kebudayaan, Riset, dan Teknologi Indonesia yang memberikan kesempatan kepada mahasiswa belajar dan mengembangkan diri menjadi calon wirausahawan melalui aktivitas di luar kelas perkuliahan.'),
('Proyek Kemanusiaan','Proyek Kemanusiaan merupakan program yang memberikan kesempatan kepada mahasiswa mengembangkan kegiatan kemanusiaan secara mandiri yang dibuktikan dengan penjelasan atau proposal kegiatan kemanusiaan.');
SELECT * FROM "Data_BKP";


INSERT INTO "Data_Mitra"(nama_mitra, deskripsi_mitra)
VALUES ('GoTo Impact Foundation', 'GoTo Impact Foundation (GIF) adalah organisasi akselerator dampak yang menggabungkan jiwa empati filantropi dengan semangat berinovasi sociopreneur'),
('Alterra Academy', 'Alterra Academy (ALTA) is a tech talent accelerator who helps potential tech talents to be the best version of themselves and help organization findin'),
('B-One Corporation', 'B One Corporation adalah perusahaan yang bergerak dalam kegiatan pelayanan di bidang Teknologi Informasi dan Komunikasi, yang telah berdiri sejak tahun 2009'),
('Direktorat Jenderal Pendidikan Tinggi', 'Direktorat Jenderal Pendidikan Tinggi (Ditjen Dikti) merupakan salah satu unit utama di Kementerian Pendidikan dan Kebudayaan'),
('Dicoding Indonesia', 'Dicoding hadir sebagai platform pendidikan teknologi yang membantu menghasilkan talenta digital berstandar global.'),
('GreatEdu', 'GreatEdu merupakan platform belajar online untuk upskilling dan reskilling'),
('Bangkit Academy', 'Bangkit adalah program kesiapan karier yang didesain oleh Google untuk memberikan mahasiswa Indonesia paparan langsung dengan praktisi industri'),
('Dinas Komunikasi dan Informatika Kota Surabaya', 'Dinas Komunikasi dan Informatika Kota Surabaya adalah Dinas yang mempunyai tugas melaksanakan kewenangan daerah di bidang pengelolaan Teknologi'),
('Data Academy', 'Data Academy is a study center for data professionals together with education, industry, government and community in building skills in Data Science and Artificial Intelligence (AI)'),
('Binar Academy', 'Binar Academy merupakan pelopor startup edtech yang fokus pada pengembangan skil dan talenta digital dengan meningkatkan pengalaman belajar');
SELECT * FROM "Data_Mitra";


INSERT INTO "Data_Program" (nama_program) 
VALUES ('Front-End Engineer Career with ReactJS'), 
('Digital Marketing with Adobe International Certification'), 
('Android Learning Path'),
('Backend Javascript'), 
('Data Analyst'), 
('Machine Learning'), 
('Instruktur Pembelajaran TIK'),
('Product Manager'),
('Fullstack Engineering'),
('UI/UX Design');
SELECT * FROM "Data_Program";


INSERT INTO "Data_Mata_Kuliah"(kode_matkul, nama_matkul, sks)
VALUES ('KMU1018', 'Pemrograman Back-End', 3),
('KMU1001', 'Komunikasi Kerja', 2),
('KMU1002', 'Critical Thinking and Problem Solving', 3),
('KIU1047', 'System Enterprise', 2),
('KIU1051', 'Soft Skill TI', 3),
('KMU1017', 'Pemrograman Front-End', 3),
('KMU1010', 'UI/UX Design', 4),
('KIU1052', 'Hard Skill TI', 3),
('KMU1016', 'Pemrograman Aplikasi Mobile', 3),
('KMU1013', 'Digital Marketing', 3);
SELECT * FROM "Data_Mata_Kuliah";


-- INSERT INTO "Data_Prodi" (nama_prodi)
-- VALUES ('Sistem Informasi'), ('Teknologi Informasi'), ('Informatika');
-- SELECT * FROM "Data_Prodi";


-- INSERT INTO "Data_Akun_Admin" (nama_admin, email, kata_sandi) 
-- VALUES ('admin','admin@gmail.com','admin');
-- SELECT * FROM "Data_Akun_Admin";

INSERT INTO "Data_Akun_Dosen" (nip, nidn, nama_dosen, no_wa, email, kata_sandi) 
VALUES ('196909281993021001', '0028096909', 'Antonius Cahya Prihandoko', '081234567891', 'antoniuscp.ilkom@unej.ac.id', 'antoniuspass123'),
('197004221995121001', '0022047001', 'Achmad Maududie', '085678901434', 'maududie@unej.ac.id', 'maududiepass'),
('198603052014042001', '0005038603', 'Diah Ayu Retnani Wulandari', '087654321098', 'diah.retnaniw@unej.ac.id', 'diahpass'),
('198706192014041001', '0019068701', 'Fahrobby Adnan', '081234267890', 'fahrobby@unej.ac.id', 'robbypass'),
('196704201992011001', '0020046701', 'Slamin', '085678501234', 'slamin@unej.ac.id', 'slaminisme'),
('196811131994121001', '0013116804', 'Saiful Bukhori', '087654331098', 'saiful.ilkom@unej.ac.id', 'sai123'),
('760016853', '0013129102', 'Diksy Media Firmansyah', '081234568890', 'diksy@unej.ac.id', 'diksy456'),
('197803302003121003', '0030037805', 'Dwiretno Istiyadi Swasono', '085378901234', 'istiyadi@unej.ac.id', 'istiyadipass789'),
('196906151997021002', '0015066902', 'Anang Andrianto', '081234567890', 'anang.uptti@unej.ac.id', 'anangpass123'),
('199110172020121002', '0017109102', 'Beny Prasetyo', '081234566453', 'beny.pssi@unej.ac.id', 'bennypass123'),
('198511282015041002', '0028118503', 'Fajrin Nurman Arifin', '08123456932', 'fajrin.pssi@unej.ac.id', 'farjrinpass123'),
('760015717', '0013118806', 'Gama Wisnu Fajarianto', '081234564435', 'gamawisnuf@unej.ac.id', 'gamapass123'),
('199301312022031005', '0031039301', 'Januar Adi Putra', '081234565437', 'januaradi.putra@unej.ac.id', 'januarpass123'),
('199512092022032023', '0009129501', 'Karina Nine Amalia', '08123453590', 'karina@unej.ac.id', 'karinapass123'),
('198101232010121003', '0023018108', 'Muhamad Arief Hidayat', '08123458984', 'arief.hidayat@unej.ac.id', 'ariefpass123'),
('198410242009122008', '0024108405', 'Nelly Oktavia Adiwijaya', '08123456903', 'nelly.oa@unej.ac.id', 'nellypass123'),
('198301312015041001', '003108303', 'Priza Pandunata', '08123458944', 'priza@unej.ac.id', 'prizapass123'),
('199407262020121005', '003108304', 'Muhammad Ariful Furqon', '08123758944', 'ariful.furqon@unej.ac.id', 'arifulpass123'),
('199111122022031011', '003108305', 'Tio Dharmawan', '08123458940', 'tio.pssi@unej.ac.id', 'tiopass456');
SELECT * FROM "Data_Akun_Dosen";


INSERT INTO "Data_Detail_Program" (id_matkul, id_program) 
VALUES (1, 4), 
(2, 7),
(3, 9),
(4, 5),
(5, 6),
(6, 1),
(7, 10),
(8, 3),
(9, 8),
(10, 2);
SELECT * FROM "Data_Detail_Program";

INSERT INTO "Data_Akun_Timmbkm" (nidn, id_dosen) VALUES 
('0031039301', 13),
('0009129501', 14),
('003108304', 18),
('003108305', 19);
SELECT * FROM "Data_Akun_Timmbkm";

INSERT INTO "Data_Akun_Mahasiswa" (nim,nama_mahasiswa,tahun_masuk,status_mahasiswa,no_wa,batch_mbkm,email,kata_sandi,id_prodi)
VALUES ('222410101005','Ayu Qomariya Putri Edyta',2022,1,'085853850540',1,'222410101005@mail.unej.ac.id','Ayu_1005',1),
('222410101012','Rinda Indriyani Shindi Shantika',2022,1,'087756252568',1,'222410101012@mail.unej.ac.id','Rinda_1012',1),
('222410101020','Shavira Febynadia',2022,1,'08113068789',1,'222410101020@mail.unej.ac.id','Shavira_1020',1),
('222410101035','Fatimatuz Zahra',2022,1,'082302526002',1,'222410101035@mail.unej.ac.id','Fatimatuz_1035',1),
('222410101037','Muhammad Faqih',2022,1,'083156922092',1,'222410101037@mail.unej.ac.id','Muhammad_1037',1),
('222410101042','Millatul Azizah',2022,1,'081231978858',1,'222410101042@mail.unej.ac.id','Millatul_1042',3),
('222410101043','Vaneca Raditya Fendyani',2022,1,'083143158444',1,'222410101043@mail.unej.ac.id','Vaneca_1043',3),
('222410101044','Abd. Muiz Samsul Arifin',2022,1,'0895606158031',1,'222410101044@mail.unej.ac.id','Abdul_1044',1),
('222410101050','Raka Febrian Syahputra',2022,1,'081233405169',1,'222410101050@mail.unej.ac.id','Raka_1050',1),
('222410101051','Nadilia Dwi Oktavia',2022,1,'082236685213',1,'222410101051@mail.unej.ac.id','Nadilia_1051',1);
SELECT * FROM "Data_Akun_Mahasiswa";

INSERT INTO "Data_Pembagian_Tugas"(id_mahasiswa, id_timmbkm)
VALUES (1,1),(2,2),(3,1),(4,1),(5,2),(6,1),(7,2),(8,1),(9,1),(10,2);
SELECT * FROM "Data_Pembagian_Tugas";