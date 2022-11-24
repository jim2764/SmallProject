using Admit.Infrastructures.DAOs;
using Admit.Models.DTOs;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admit.Models.Services
{
	public class BookManagementServices
	{

		/// <summary>
		/// if(NAN) return -1
		/// if(string.Empty) return 0
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		public int StringTOInt(string input)
		{
			if (input == string.Empty) return 0;

			int failoutput = -1;
			bool isInt = int.TryParse(input, out int result);
			return isInt ? result : failoutput;
		}

		public void InsertBook(BookDTO dto, string sourcePath)
		{
			// Validation
			dto = InsertValidae(dto);

			AddImageToFile(sourcePath);

			// Insert to DatBase
			BookManagementDAO dao = new BookManagementDAO();
			dao.BookInsert(dto);
		}

		public void UpdateBook(BookDTO dto, string sourcePath)
		{
			// Validation
			dto = UpdateValidae(dto);

			// Determine Whether Image Update
			BookManagementDAO dao = new BookManagementDAO();
			string filename = dao.GetBook(dto.BookID).FileName;
			if(dto.FileName != filename)
			{
				// Update file image
				AddImageToFile(sourcePath);

				// Delete file image
				DeleteFileImage(filename);
			}

			// Insert to DatBase
			dao.BookUpdate(dto);
		}

		public void DeleteBook(BookDTO dto, string filename)
		{
			// Validation
			dto = DeleteValidae(dto);

			// Delete file image
			if (HasImage(filename)) DeleteFileImage(filename);

			// Insert to DatBase
			BookManagementDAO dao = new BookManagementDAO();
			dao.BookDelete(dto.BookID);
		}

		public bool TryAddImage(OpenFileDialog openFileDialog, out string path)
		{
			path = string.Empty;
			openFileDialog.InitialDirectory = "C:";
			openFileDialog.Title = "Please select an image";
			openFileDialog.Filter = "Image Only(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";

			if (openFileDialog.ShowDialog() != DialogResult.OK) return false;
			else
			{
				path = openFileDialog.FileName;
				return true;
			}
		}

		public bool HasImage(string filename)
		{
			if (filename == string.Empty || filename == "No File") return false;
			else return true;
		}

		private void AddImageToFile(string sourcePath)
		{
			if (sourcePath == "No Picture") return;

			// No add image to file if database has this image
			string filename = System.IO.Path.GetFileName(sourcePath);
			BookManagementDAO dao = new BookManagementDAO();
			if (dao.HasThisImage(filename) > 0) return;

			// Get destinationPath
			string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
			string destinationPath = path + "\\Image\\" + filename;

			// Move File
			System.IO.File.Copy(sourcePath, destinationPath);
		}

		private void DeleteFileImage(string filename)
		{
			// No delete image to file if database has this image
			BookManagementDAO dao = new BookManagementDAO();
			if (dao.HasThisImage(filename) > 1) return;

			// Get Path + FileName
			string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
			string destinationPath = path + "\\Image\\" + filename;

			// Delete
			System.IO.File.Delete(destinationPath);
		}

		private BookDTO InsertValidae(BookDTO dto)
		{
			// BookID Validation
			string BookId = dto.BookID;
			bool isValidBookID = BookId.StartsWith("B");
			if (!isValidBookID) throw new Exception("BookId is not Valid");

			// TotalAmount Valiadtion
			if (dto.TotalAmount <= 0) throw new Exception("TotalAmount is not Valid");

			// No Image
			if (dto.FileName == "No File") dto.FileName = string.Empty;

			return dto;
		}

		private BookDTO UpdateValidae(BookDTO dto)
		{
			// TotalAmount Valiadtion
			// TotalAmount must be bigger than zero
			if (dto.TotalAmount <= 0) throw new Exception("TotalAmount is not Valid");

			// TotalAmount must be bigger than borrowed book
			BookManagementDAO dao = new BookManagementDAO();
			int borrowedBookAmount = dao.TotalBorrowAmount(dto);
			dao.TotalBorrowAmount(dto);
			if (borrowedBookAmount - dto.TotalAmount > 0) throw new Exception("TotalAmount can not less than borrowed book");

			// Determine whether book is borrowed
			if (dto.TotalAmount - borrowedBookAmount != dto.TotalAmount) throw new Exception("Book is borrowed, don't update");

			// No Image
			if (dto.FileName == "No File") dto.FileName = string.Empty;

			return dto;
		}

		private BookDTO DeleteValidae(BookDTO dto)
		{
			// Determine whether book is borrowed
			BookManagementDAO dao = new BookManagementDAO();
			int borrowedBookAmount = dao.TotalBorrowAmount(dto);

			if (dto.TotalAmount - borrowedBookAmount != dto.TotalAmount) throw new Exception("Book is borrowed, don't delete");

			return dto;
		}
	}
}
