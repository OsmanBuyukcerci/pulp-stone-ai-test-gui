from email import message
import sys
import os
import json
from ultralytics import YOLO
from datetime import datetime

def main():
    if len(sys.argv) < 2:
        print("JSON argument missing.")

    json_path = sys.argv[1]

    try:
        with open(json_path, 'r') as file:
            data = json.load(file)
        
        confidence = data["confidence"]
        imagePaths = data["images"]
        model_name = data["model"]
        settings = data["settings"]

        showResults = False

        for setting in settings:
            if setting == 2:
                showResults = True
        

        script_dir = os.path.dirname(os.path.abspath(__file__))
        results_dir = os.path.join(script_dir, "results")

        models_folder_path = os.path.join(script_dir, "models")
        model_path = os.path.join(models_folder_path, model_name)

        if not os.path.exists(model_path):
            print_message(f"Model bulunamadi: {model_path}")
            return 

        model = YOLO(model_path)

        print_message(f"Model tanimlandi: {model_name}")

        print_message(f"Confidence: {confidence}")

        print_message("Resim isleme islemi baslatiliyor...")

        project_dir = os.path.join(results_dir, model_name)

        result_dir = "predict" + " " + get_current_datetime_now()

        for path in imagePaths:
            print_message(f"Islenen resim: {path}")
            results = model.predict(
                source=path, 
                conf=confidence, 
                project = project_dir,
                name = result_dir,
                save=True,)
            print_message(f"Resim isleme tamamlandi: {path}")

            if showResults: 
                results[0].show()
        for setting in settings:
            if showResults: 
                os.startfile(os.path.join(project_dir))

        print_message("Python script sonlandiriliyor...")
    except json.JSONDecodeError as e:
        print_message("Invalid JSON argument: " + str(e))
        return

def get_current_datetime_now():
    return datetime.now().strftime("%Y-%m-%d_%H-%M-%S")

def print_message(message):
    print(f"[{get_current_datetime_now()}] {message}")

main()