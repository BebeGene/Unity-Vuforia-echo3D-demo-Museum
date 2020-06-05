## Vuforia-echoAR-Unity- Museum Demo
Example Unity project getting information about art using echoAR and Vuforia

## Register
Don't have an API key? Make sure to register for FREE at [echoAR](https://console.echoar.xyz/#/auth/register).

## Setup
Follow the instructions on our [documentation page](https://docs.echoar.xyz/unity/adding-ar-capabilities) to [set your API key](https://docs.echoar.xyz/unity/adding-ar-capabilities#3-set-you-api-key).
* Clone this project and open the project in Unity, and open the *Museum* scene.
* Open the *echoAR* folder, click the echoAR prefab, and enter your API key.
* Upload the models from the [Models](/Models) folder to your echoAR project.
* Add in the metadata from metadata.csv in the [Models](/Models) folder.

## Vuforia
1. Register to Vufoeia
2. In [Vuforia's develpoers page](https://developer.vuforia.com/vui/develop/licenses), create a new license key by clicking *Get Development Key* and following the instructions. Click the new license and copy the license key.
3. Click *Target Manager* and add a new database. The new Database should be set to "Device".
4. Click the new database and add the targets from the [Targets](/Tragets) folder.
5. When you are done uploading the targets, click *Download Database* and choose *Unity Editor*. After its done downloading double click the downloaded file and import it to unity.
6. In Unity click the AR camera and then click the *Open Vuforia Engine Configuration* button in the inspector. Paste the license key you copied in step 2 to the *App license Key* input.

## Unity - Next Steps
1. In Unity , click the targets in the scene and in the *Image Target Behaviour* section, choose your database and the image for the target.

## Run
Simply press the _Play_ button in Unity. Now you should be able to see the painting information on the painting. Clicking the information will redirect you to the wikipedia page of the painting.

## Adjusting information model
You can easily change the information model location and size by following [adding information](https://docs.echoar.xyz/unity/using-the-sdk#build-in-keywords) to its entry on echoAR. 

## Learn more
Refer to our [documentation](https://docs.echoar.xyz/unity/) to learn more about how to use Unity and echoAR.

## Support
Feel free to reach out at [support@echoAR.xyz](mailto:support@echoAR.xyz) or join our [support channel on Slack](https://join.slack.com/t/echoar/shared_invite/enQtNTg4NjI5NjM3OTc1LWU1M2M2MTNlNTM3NGY1YTUxYmY3ZDNjNTc3YjA5M2QyNGZiOTgzMjVmZWZmZmFjNGJjYTcxZjhhNzk3YjNhNjE).

## Screenshots
![Vuforia - Create DB](/screenshots/CreateDB.jpg)
![Vuforia - Download DB](/screenshots/DownloadDB.jpg)
