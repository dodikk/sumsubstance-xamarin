//
//  AppDelegate.h
//  Sumsub-iOS
//
//  Created by dodikk on 28.01.2020.
//  Copyright © 2020 sumsubstance. All rights reserved.
//

#import <UIKit/UIKit.h>
#import <CoreData/CoreData.h>

@interface AppDelegate : UIResponder <UIApplicationDelegate>

@property (readonly, strong) NSPersistentContainer *persistentContainer;

- (void)saveContext;


@end

