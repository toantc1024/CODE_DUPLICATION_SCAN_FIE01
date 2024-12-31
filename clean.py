import os
import shutil

def is_debug_folder(path):
    return 'bin\\debug' in path.lower() or 'obj\\debug' in path.lower()

def clean_directory(directory):
    allowed_extensions = {'.cpp', '.cs'}
    
    for root, dirs, files in os.walk(directory, topdown=True):
        # Handle Debug folders
        for dir_name in dirs[:]:  # Create a copy of dirs to modify during iteration
            dir_path = os.path.join(root, dir_name)
            if is_debug_folder(dir_path):
                try:
                    shutil.rmtree(dir_path)
                    print(f"Removed Debug folder: {dir_path}")
                except Exception as e:
                    print(f"Error removing debug folder {dir_path}: {e}")
        
        # Handle files
        for file in files:
            file_path = os.path.join(root, file)
            file_extension = os.path.splitext(file)[1].lower()
            
            if file_extension not in allowed_extensions:
                try:
                    os.remove(file_path)
                    print(f"Removed file: {file_path}")
                except Exception as e:
                    print(f"Error removing {file_path}: {e}")

if __name__ == "__main__":
    current_directory = os.getcwd()
    print(f"Cleaning directory: {current_directory}")
    print("This will remove non-cpp/cs files and Debug folders")
    clean_directory(current_directory)
    print("Cleanup complete!")
