from PyPDF2 import PdfReader

# Abrir el archivo PDF
pdf_file = open('114319A1.pdf', 'rb')

# Crear un objeto PDFReader
pdf_reader = PdfReader(pdf_file)

page = pdf_reader.pages[0]
print(page)
# Cerrar el archivo PDF
pdf_file.close()