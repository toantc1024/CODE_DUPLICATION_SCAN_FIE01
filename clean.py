import os
import shutil

def is_debug_folder(path):
    return 'bin\\debug' in path.lower() or 'obj\\debug' in path.lower()

def is_release_folder(path):
    return 'obj\\release' in path.lower()

def clean_directory(directory):
    allowed_extensions = {'.cpp', '.cs', '.yml', '.py'}
    
    for root, dirs, files in os.walk(directory, topdown=True):
        # Handle Debug and Release folders
        for dir_name in dirs[:]:  # Create a copy of dirs to modify during iteration
            dir_path = os.path.join(root, dir_name)
            if is_debug_folder(dir_path) or is_release_folder(dir_path):
                try:
                    shutil.rmtree(dir_path)
                    print(f"Removed folder: {dir_path}")
                except Exception as e:
                    print(f"Error removing folder {dir_path}: {e}")
        
        # Handle files
        for file in files:
            file_path = os.path.join(root, file)
            file_extension = os.path.splitext(file)[1].lower()
            
            # Remove Designer.cs files or files with non-allowed extensions
            if file.endswith('Designer.cs') or file_extension not in allowed_extensions:
                try:
                    os.remove(file_path)
                    print(f"Removed file: {file_path}")
                except Exception as e:
                    print(f"Error removing {file_path}: {e}")

if __name__ == "__main__":
    current_directory = os.getcwd()
    print(f"Cleaning directory: {current_directory}")
    print("This will remove non-cpp/cs files, Debug/Release folders, and Designer.cs files")
    clean_directory(current_directory)
    print("Cleanup complete!")
